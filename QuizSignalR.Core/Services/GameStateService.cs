using QuizSignalR.Core.Contracts;
using QuizSignalR.Core.Models;
using QuizSignalR.Core.Models.Enums;
using QuizSignalR.Infrastructure.Models;
using QuizSignalR.Infrastructure.Models.Enums;

namespace QuizSignalR.Core.Services
{
    public class GameStateService : IGameStateService
    {
        private readonly INotificationService _notificationService;
        private readonly IGameLobbyService _gameLobbyService;

        public GameStateService(
            INotificationService notificationService,
            IGameLobbyService gameLobbyService)
        {
            _notificationService = notificationService;
            _gameLobbyService = gameLobbyService;
        }

        public async Task RegisterPlayers(string contextConnectionId, string playerName)
        {
            var player = new Player { Name = playerName, ConnectionId = contextConnectionId, Score = 0 };
            var result = await _gameLobbyService.TryAddPlayerToGameAsync(player);

            switch (result.Status)
            {
                case AddPlayerResultStatus.EmptyName:
                    await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", "Name cannot be emty!"));
                    break;
                case AddPlayerResultStatus.NameTaken:
                    await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", $"There is a player with name {playerName} already in the lobby!"));
                    break;
                case AddPlayerResultStatus.AlreadyRegisteredInGame:
                    await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", "You are already registered!"));
                    break;
                case AddPlayerResultStatus.GameFull:
                    await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", "Sorry, the game is already full!"));
                    break;
                case AddPlayerResultStatus.Success:
                    var gameSession = result.GameSession!;

                    await _notificationService.AddToGroupAsync(contextConnectionId, gameSession.GameId);
                    await _notificationService.SendMessageGroupAsync(gameSession.GameId, "ReceiveMessage", new PlayerMessage(player.Name, "Joined the lobby!"));

                    if (gameSession.IsFull)
                    {
                        await SendQuestion(gameSession);
                    }
                    break;
                default:
                    break;
            }

            //_gameSession.Players.TryAdd(contextConnectionId, player);
            //var gameSession = await _gameLobbyService.FindOrCreateGameAsync(player);
            //await _notificationService.AddToGroupAsync(contextConnectionId, gameSession.GameId);
            ////await _notificationService.SendMessageGroupAsync(gameSession.GameId, "UpdatePlayers", currentPlayers.Values.ToList());
            //await _notificationService.SendMessageGroupAsync(gameSession.GameId, "ReceiveMessage", new PlayerMessage(player.Name, "Joined the lobby!"));

            ////await _notificationService.SendMessageToAllClientsAsync("UpdatePlayers", currentPlayers.Values.ToList());
            ////await _notificationService.SendMessageToAllClientsAsync("ReceiveMessage", new PlayerMessage(player.Name, "Joined the lobby!"));

        }

        public async Task SendQuestion(GameSession gameSession)
        {
            //var randomQuestion = await _questionService.GetRandomQuestion();
            //if (randomQuestion.Answers.Any(a => a.Question == randomQuestion))
            //{
            //    Console.WriteLine("Circular reference detected!");
            //}
            //var jsonQuestionConvert = JsonSerializer.Serialize(randomQuestion);
            //var jsonQuestionConvert = JsonSerializer.Serialize(randomQuestion, new JsonSerializerOptions
            //{
            //    ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles,
            //    WriteIndented = true
            //});
            //if (_gameState.CurrentQuestion != null)

            if (gameSession.CurrentQuestionIndex >= gameSession.Questions.Count)
            {
                await EndGame(gameSession);
                return;
            }

            await _notificationService.SendQuestion(gameSession.GameId, gameSession.Questions.ToList()[gameSession.NextQuestionIndex]);
        }

        private async Task EndGame(GameSession gameSession)
        {
            gameSession.GameHasEnded = true;

            string engGameMessage;
            var disconnectedPlayer = gameSession.Players.Values.FirstOrDefault(p => p.Status == PlayerStatus.Disconnected);

            if (disconnectedPlayer != null)
            {
                var winner = gameSession.Players.Values.FirstOrDefault(p => p.Status == PlayerStatus.Active);

                if (winner != null)
                {
                    engGameMessage = $"Game Over! {disconnectedPlayer.Name} disconnected. {winner.Name} is the winner!";
                }
                else
                {
                    // This covers the edge case where both players disconnect almost simultaneously.
                    engGameMessage = "Game Over! Both players have disconnected.";
                }
            }
            else
            {
                var orderedPlayers = gameSession.Players.Values.OrderByDescending(p => p.Score).ToList();
                var winner = orderedPlayers[0];
                var loser = orderedPlayers[1];

                if (winner.Score > loser.Score)
                {
                    engGameMessage = $"Game Over! {winner.Name} wins with a final score of {winner.Score} to {loser.Name}'s {loser.Score}!";
                }
                else // Their scores are equal.
                {
                    engGameMessage = $"Game Over! It's a tie! Both players finished with {winner.Score} points!";
                }
            }
                await _notificationService.SendMessageGroupAsync(gameSession.GameId, "GameOver", engGameMessage);

                // Cancel any outstanding question timer to prevent further processing
                //gameSession.CurrentQuestionTokenSource?.Cancel();

            //await Task.Delay(TimeSpan.FromSeconds(10));
            _gameLobbyService.RemoveGame(gameSession.GameId);
        }

        public async Task RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken)
        {
            var gameSession = _gameLobbyService.GetGameSessionForPlayer(contextConnectionId);
            if (gameSession == null || gameSession.GameHasEnded)
            {
                return;
            }

            if (!gameSession.Players.TryGetValue(contextConnectionId, out Player currentPlayer))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "Player not found.");
            }

            if (gameSession.PlayersAnswers.ContainsKey(currentPlayer.ConnectionId))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "You have already answered this question!");
            }

            gameSession.PlayersAnswers[contextConnectionId] = (currentPlayer, answer, timeTaken);
            var otherPlayer = gameSession.Players.Where(p => p.Value.ConnectionId != contextConnectionId).FirstOrDefault();
            await _notificationService.SendMessageClient(otherPlayer.Key, "HighlightAnswer", answer);

            if (gameSession.PlayersAnswers.Count == 2)
            {
                //await Task.Delay(TimeSpan.FromSeconds(2));
                await ProcessAnswers(gameSession);
            }
        }

        public async Task ProcessAnswers(GameSession gameSession)
        {
            if (gameSession != null && gameSession.Players.Count == 2)
            {
                foreach (var playerAnswer in gameSession.PlayersAnswers)
                {
                    var (playerId, (Player, PlayerAnswer, PlayerTime)) = playerAnswer;
                    if (PlayerAnswer.IsCorrect)
                    {
                        Player.Score += (int)PlayerTime;
                    }
                    await _notificationService.SendMessageGroupAsync(gameSession.GameId, "PlayerAnswered", new PlayerAnswerData(Player.Name, PlayerAnswer.AnswerText, PlayerAnswer.IsCorrect, (int)PlayerTime));
                }

                //await _notificationService.SendMessageToAll("Both players have answered. Proceeding to the next question.");
                await _notificationService.SendMessageGroupAsync(gameSession.GameId, "UpdatePlayers", gameSession.Players.Values.ToList());

                gameSession.PlayersAnswers.Clear();
                await SendQuestion(gameSession);
            }
        }

        public async Task Disconnect(string contextConnectionId)
        {
            var gameSession = _gameLobbyService.GetGameSessionForPlayer(contextConnectionId);
            if (gameSession != null && !gameSession.GameHasEnded)
            {
                if (gameSession!.Players.TryGetValue(contextConnectionId, out var disconnectedPlayer))
                {
                    disconnectedPlayer.Status = PlayerStatus.Disconnected;
                    await _notificationService.SendMessageGroupAsync(gameSession.GameId, "ReceiveMessage", new PlayerMessage(disconnectedPlayer.Name, "Left the game! (chicken!)"));
                    await EndGame(gameSession);
                }
            }
        }
    }
}
