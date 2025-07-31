using QuizSignalR.Core.Contracts;
using QuizSignalR.Core.Models;
using QuizSignalR.Infrastructure.Models;

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
            await _notificationService.SendMessageGroupAsync(gameSession.GameId, "GameOver", gameSession.Players.Values);
            //await Task.Delay(TimeSpan.FromSeconds(10));
            _gameLobbyService.RemoveGame(gameSession.GameId);
        }

        public async Task RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken)
        {
            var gamseSession = _gameLobbyService.GetGameSessionForPlayer(contextConnectionId);
            if (gamseSession == null || gamseSession.GameHasEnded)
            {
                return;
            }

            if (!gamseSession.Players.TryGetValue(contextConnectionId, out Player currentPlayer))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "Player not found.");
            }

            if (gamseSession.PlayersAnswers.ContainsKey(currentPlayer.ConnectionId))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "You have already answered this question!");
            }

            gamseSession.PlayersAnswers[contextConnectionId] = (currentPlayer, answer, timeTaken);
            if (gamseSession.PlayersAnswers.Count == 2)
            {
                await ProcessAnswers(gamseSession);
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
    }
}
