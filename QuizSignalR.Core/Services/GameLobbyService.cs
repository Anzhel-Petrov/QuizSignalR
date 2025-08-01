using Microsoft.Extensions.DependencyInjection;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Core.Models;
using QuizSignalR.Core.Models.Enums;
using QuizSignalR.Infrastructure.Models;
using System.Collections.Concurrent;

namespace QuizSignalR.Core.Services
{
    public class GameLobbyService : IGameLobbyService
    {
        // Holds all active games, keyed by GameId
        private readonly ConcurrentDictionary<string, GameSession> _activeGames = new();

        // Maps a player's ConnectionId to their GameId for quick lookups
        private readonly ConcurrentDictionary<string, string> _playerGameMap = new();

        // Injected service to load questions
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly object _lobbyLock = new object();

        public GameLobbyService(IServiceScopeFactory serviceScopeFactory)
        {
            _scopeFactory = serviceScopeFactory;
        }

        public async Task<GameSession> FindOrCreateGameAsync(Player player)
        {
            // Try to find a game that is waiting for a second player
            var waitingGame = _activeGames.Values.FirstOrDefault(g => !g.IsFull);

            if (waitingGame != null)
            {
                // Found a game, add the player to it
                waitingGame.Players.TryAdd(player.ConnectionId, player);
                _playerGameMap.TryAdd(player.ConnectionId, waitingGame.GameId);
                return waitingGame;
            }
            else
            {
                // No waiting games, create a new one
                var newGame = new GameSession();
                newGame.Players.TryAdd(player.ConnectionId, player);
                using (var scope = _scopeFactory.CreateScope())
                {
                    var questionsService = scope.ServiceProvider.GetRequiredService<IQuestionService>();
                    newGame.Questions = await questionsService.LoadRandomQuestions(10); // Load questions for this new game
                }

                _activeGames.TryAdd(newGame.GameId, newGame);
                _playerGameMap.TryAdd(player.ConnectionId, newGame.GameId);
                return newGame;
            }
        }

        public GameSession? GetGameSessionForPlayer(string connectionId)
        {
            if (_playerGameMap.TryGetValue(connectionId, out var gameId))
            {
                _activeGames.TryGetValue(gameId, out var gameSession);
                return gameSession;
            }
            return null;
        }

        public void RemoveGame(string gameId)
        {
            if (_activeGames.TryRemove(gameId, out var gameSession))
            {
                // Remove all players from the player-to-game map
                foreach (var player in gameSession.Players.Values)
                {
                    _playerGameMap.TryRemove(player.ConnectionId, out _);
                }
            }
        }

        public async Task<AddPlayerResult> TryAddPlayerToGameAsync(Player player)
        {
            if (string.IsNullOrEmpty(player.Name.Trim()))
            {
                return new AddPlayerResult { Status = AddPlayerResultStatus.EmptyName };
            }

            GameSession? targetGame;

            // The lock ensures that finding a game and joining it is an atomic operation,
            // preventing race conditions.
            lock (_lobbyLock)
            {
                targetGame = _activeGames.Values.FirstOrDefault(g => !g.IsFull);

                if (targetGame != null)
                {
                    // Game found, let's validate and add the player.
                    if (targetGame.Players.Values.Any(p => p.Name.Equals(player.Name, StringComparison.OrdinalIgnoreCase)))
                    {
                        return new AddPlayerResult { Status = AddPlayerResultStatus.NameTaken };
                    }

                    if(targetGame.Players.ContainsKey(player.ConnectionId))
                    {
                        return new AddPlayerResult { Status = AddPlayerResultStatus.AlreadyRegisteredInGame };
                    }

                    // Add player to the existing game
                    targetGame.Players.TryAdd(player.ConnectionId, player);
                    _playerGameMap.TryAdd(player.ConnectionId, targetGame.GameId);
                }
                else
                {
                    // No waiting games, create a new one
                    targetGame = new GameSession();
                    targetGame.Players.TryAdd(player.ConnectionId, player);

                    _activeGames.TryAdd(targetGame.GameId, targetGame);
                    _playerGameMap.TryAdd(player.ConnectionId, targetGame.GameId);
                }
            }

            // Load questions outside of the lock if a new game was created.
            if (targetGame.Players.Count == 1)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var questionService = scope.ServiceProvider.GetRequiredService<IQuestionService>();
                    targetGame.Questions = await questionService.LoadRandomQuestions(1);
                }
            }

            return new AddPlayerResult { Status = AddPlayerResultStatus.Success, GameSession = targetGame };
        }
    }
}
