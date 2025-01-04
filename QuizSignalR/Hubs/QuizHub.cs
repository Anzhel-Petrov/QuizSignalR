using Microsoft.AspNetCore.SignalR;
using QuizSignalR.Models;

namespace QuizSignalR.Hubs;

public class QuizHub : Hub
{
    private static GameState _gameState = new GameState();
    // This should be replaced by something persistent, like a database or json
    private static List<Question> _questions = new List<Question>()
        {
            new Question { Id = 1, Text = "What is 2+2?", Options = new List<string> { "3", "4", "5", "6" }, CorrectAnswer = "4" },
            new Question { Id = 1, Text = "What is the capital of France?", Options = new List<string> { "Paris", "Berlin", "London", "Rome" }, CorrectAnswer = "Paris" }
        };


    public override async Task OnConnectedAsync()
    {
        await Clients.Caller.SendAsync("ReceiveMessage", "Server", "Welcome! Please enter your name.");
        if (_gameState.Questions.Count == 0)
            _gameState.Questions = _questions;
        await base.OnConnectedAsync();
    }

    public async Task RegisterPlayer(string playerName)
    {
        if (!_gameState.Players.ContainsKey(Context.ConnectionId))
        {
            var player = new Player { Name = playerName, ConnectionId = Context.ConnectionId, Score = 0 };
            _gameState.Players.Add(Context.ConnectionId, player);
            await Clients.All.SendAsync("UpdatePlayers", _gameState.Players.Values.ToList());
            await Clients.All.SendAsync("ReceiveMessage", player.Name, "Joined the lobby!");
            if (_gameState.Players.Count == 2)
            {
                await StartGame();
            }
        }
        else
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "Server", "You are already registered!");
        }

    }

    public async Task StartGame()
    {
        if (_gameState.Players.Count == 2 && !_gameState.GameEnded)
        {
            _gameState.CurrentQuestionIndex = 0;
            await SendCurrentQuestion();
        }

    }


    public async Task AnswerQuestion(string answer, long timeTaken)
    {
        if (_gameState.CurrentQuestion != null)
        {
            Player currentPlayer;
            _gameState.Players.TryGetValue(Context.ConnectionId, out currentPlayer);

            if (currentPlayer != null)
            {
                string correctAnswer = _gameState.CurrentQuestion.CorrectAnswer;
                bool isCorrect = answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase);

                int score = 0;
                if (isCorrect)
                    score = (int)timeTaken;


                currentPlayer.Score += score;
                await Clients.All.SendAsync("PlayerAnswered", currentPlayer, isCorrect, _gameState.Players.Values.ToList());

                await NextQuestion();
            }

        }

    }

    public async Task NextQuestion()
    {
        _gameState.CurrentQuestionIndex++;
        if (_gameState.CurrentQuestionIndex >= _gameState.Questions.Count)
        {
            _gameState.GameEnded = true;
            await Clients.All.SendAsync("GameOver", _gameState.Players.Values.ToList());
        }
        else
        {
            await SendCurrentQuestion();
        }
    }

    public async Task SendCurrentQuestion()
    {
        if (_gameState.CurrentQuestion != null)
            await Clients.All.SendAsync("ReceiveQuestion", _gameState.CurrentQuestion);
    }
}