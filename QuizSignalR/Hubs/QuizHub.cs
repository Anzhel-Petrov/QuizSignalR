using Microsoft.AspNetCore.SignalR;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Hubs;

public class QuizHub : Hub
{
    private static GameState _gameState = new GameState();
    private readonly IGameService _gameService;
    private readonly IGameStateService _gameStateService;

    public QuizHub(IGameService gameService, IGameStateService gameStateService)
    {
        this._gameService = gameService;
        this._gameStateService = gameStateService;
    }

    public override async Task OnConnectedAsync()
    {
        await Clients.Caller.SendAsync("ReceiveMessage", "Server", "Welcome! Please enter your name.");
        //if (_gameState.Questions.Count == 0)
        //    //_gameState.Questions = _questions;
        await base.OnConnectedAsync();
    }

    public async Task RegisterPlayer(string playerName)
    {
        if (!_gameState.Players.ContainsKey(Context.ConnectionId))
        {
            if (_gameState.Players.Values.Any(p => p.Name == playerName))
            {
                await Clients.Caller.SendAsync("ReceiveMessage", "Server", $"There is a player with {playerName} already in the lobby!");
                return;
            }

            var player = new Player { Name = playerName, ConnectionId = Context.ConnectionId, Score = 0 };
            _gameState.Players.Add(Context.ConnectionId, player);
            await Clients.All.SendAsync("UpdatePlayers", _gameState.Players.Values.ToList());
            await _gameService.SendMessage(player.Name, "Joined the lobby!");
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


    public async Task AnswerQuestion(Answer answer, long timeTaken)
    {
        // Check if there is a current question
        //if (_gameState.CurrentQuestion == null)
        //{
        //    await Clients.Caller.SendAsync("ReceiveMessage", "There is no current question.");
        //    return;
        //}

        // Retrieve the current player using the connection ID
        if (!_gameState.Players.TryGetValue(Context.ConnectionId, out Player currentPlayer))
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "Player not found.");
            return;
        }

        // Store the player's answer and the time taken

        if (_gameStateService.GetPlayerAnswers().ContainsKey(currentPlayer.ConnectionId))
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "You have already answered this question!");
            return;
        }

        _gameStateService.AddOrUpdatePlayerAnswer(currentPlayer.ConnectionId, answer, timeTaken);

        // Check if both players have answered
        if (_gameStateService.HaveAllPlayersAnswered(2))
        {
            foreach (var playerAnswer in _gameStateService.GetPlayerAnswers())
            {
                Player player = _gameState.Players[playerAnswer.Key];
                if (playerAnswer.Value.answer.IsCorrect)
                {
                    // Add the time taken to the player's score
                    player.Score += (int)playerAnswer.Value.timeTaken;
                }
            }

            // Notify both players about the results or proceed to the next question
            //await _notificationService.SendMessageToAll("Both players have answered. Proceeding to the next question.");
            await Clients.All.SendAsync("PlayerAnswered", currentPlayer, answer.AnswerText, answer.IsCorrect, _gameState.Players.Values.ToList());

            // Clear the answers for the next question
            _gameStateService.ClearPlayerAnswers();

            await NextQuestion();
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
        //if (_gameState.CurrentQuestion != null)
        await _gameService.SendQuestion();
    }
}