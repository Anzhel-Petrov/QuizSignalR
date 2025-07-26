using QuizSignalR.Core.Contracts;
using QuizSignalR.Core.Models;
using QuizSignalR.Infrastructure.Models;
using System.Collections.Concurrent;

namespace QuizSignalR.Core.Services
{
    public class GameStateService : IGameStateService
    {
        private readonly INotificationService _notificationService;
        private readonly IQuestionService _questionService;
        private readonly GameStateContainer _gameStateContainer;
        private bool _gameHasEnded;
        private ICollection<Question> _questions;

        public GameStateService(INotificationService notificationService, IQuestionService questionService, GameStateContainer gameStateContainer)
        {
            _notificationService = notificationService;
            _questionService = questionService;
            _gameStateContainer = gameStateContainer;
            this._questions = new HashSet<Question>();
        }

        public ICollection<Question> Questions { get => this._questions; set => this._questions = value; }
        public Question CurrentQuestion { get; set; } = null!;
        public bool GameHasEnded => this._gameHasEnded;
        bool IGameStateService.GameHasEnded { get => this._gameHasEnded; set => this._gameHasEnded = value; }
        public ConcurrentDictionary<string, (Player player, Answer answer, double timeTaken)> GetPlayerAnswers()
        {
            return _gameStateContainer.PlayersAnswers;
        }

        public bool HaveAllPlayersAnswered()
        {
            throw new NotImplementedException();
        }

        public async Task RegisterPlayers(string contextConnectionId, string playerName)
        {
            var currentPlayers = _gameStateContainer.Players;
            if (!_gameStateContainer.PlayersAnswers.ContainsKey(contextConnectionId))
            {
                if (currentPlayers.Values.Any(p => p.Name == playerName))
                {
                    await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", $"There is a player with name {playerName} already in the lobby!"));
                    return;
                }

                var player = new Player { Name = playerName, ConnectionId = contextConnectionId, Score = 0 };
                currentPlayers.TryAdd(contextConnectionId, player);
                await _notificationService.SendMessageToAllClientsAsync("UpdatePlayers", currentPlayers.Values.ToList());
                await _notificationService.SendMessageToAllClientsAsync("ReceiveMessage", new PlayerMessage(player.Name, "Joined the lobby!"));

            }
            else
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", new PlayerMessage("Server", "You are already registered!"));
            }
        }

        public async Task LoadQuestions(int numberOfQuestions)
        {
            _gameStateContainer.Questions = await _questionService.LoadRandomQuestions(numberOfQuestions);
            var foo = GetQuestionsCount();
        }

        public async Task SendQuestion()
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
            if (_gameStateContainer.CurrentQuestionIndex >= _gameStateContainer.Questions.Count)
            {
                //_gameStateService.GameHasEnded = true;
                await _notificationService.SendMessageToAllClientsAsync("GameOver", _gameStateContainer.Players);
            }
            else
            {
                await _notificationService.SendQuestion(_gameStateContainer.Questions.ToList()[_gameStateContainer.CurrentQuestionIndex]);
                _gameStateContainer.CurrentQuestionIndex++;
            }
        }

        public async Task<bool> RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken)
        {
            var currentPlayers = _gameStateContainer.Players;
            var playersAnswers = _gameStateContainer.PlayersAnswers;

            if (!currentPlayers.TryGetValue(contextConnectionId, out Player currentPlayer))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "Player not found.");
                return false;
            }

            if (playersAnswers.ContainsKey(currentPlayer.ConnectionId))
            {
                await _notificationService.SendMessageClient(contextConnectionId, "ReceiveMessage", "You have already answered this question!");
                return false;
            }

            _gameStateContainer.PlayersAnswers[contextConnectionId] = (currentPlayer, answer, timeTaken);
            return _gameStateContainer.PlayersAnswers.Count == 2;
        }

        public async Task ProcessAnswers(string contextConnectionId)
        {
            var currentPlayers = _gameStateContainer.Players;
            var playersAnswers = _gameStateContainer.PlayersAnswers;

            if (playersAnswers.Count == 2)
            {
                foreach (var playerAnswer in playersAnswers)
                {
                    var (playerId, (Player, PlayerAnswer, PlayerTime)) = playerAnswer;
                    if (PlayerAnswer.IsCorrect)
                    {
                        Player.Score += (int)PlayerTime;
                    }
                    await _notificationService.SendMessageToAllClientsAsync("PlayerAnswered", new PlayerAnswerData(Player.Name, PlayerAnswer.AnswerText, PlayerAnswer.IsCorrect, (int)PlayerTime));
                }

                // Notify both players about the results or proceed to the next question
                //await _notificationService.SendMessageToAll("Both players have answered. Proceeding to the next question.");
                var foo = playersAnswers.Values;
                await _notificationService.SendMessageToAllClientsAsync("UpdatePlayers", currentPlayers.Values.ToList());

                playersAnswers.Clear();
            }
        }

        public Task<int> GetPlayerCount()
        {
            int playerCount = _gameStateContainer.Players.Count;
            return Task.FromResult(playerCount);
        }

        public ICollection<Player> GetPlayers()
        {
            return _gameStateContainer.Players.Values.ToList();
        }

        public int GetQuestionsCount()
        {
            return _gameStateContainer.Questions.Count;
        }
    }
}
