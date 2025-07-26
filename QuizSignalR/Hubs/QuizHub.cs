using Microsoft.AspNetCore.SignalR;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Hubs;

public class QuizHub : Hub
{
    //private readonly IGameService _gameService;
    private readonly IGameStateService _gameStateService;

    public QuizHub(IGameStateService gameStateService)
    {
        //this._gameService = gameService;
        this._gameStateService = gameStateService;
    }

    public override async Task OnConnectedAsync()
    {
        //await _gameService.SendMessageClient(Context.ConnectionId, "ReceiveMessage", "Server", "Welcome! Please enter your name.");
        //if (_gameState.Questions.Count == 0)
        //    //_gameState.Questions = _questions;
        await base.OnConnectedAsync();
    }

    public async Task RegisterPlayer(string playerName)
    {
        await _gameStateService.RegisterPlayers(Context.ConnectionId, playerName);
        if (await _gameStateService.GetPlayerCount() == 2)
        {
            await _gameStateService.LoadQuestions(5);
            await StartGame();
        }
    }

    public async Task StartGame()
    {
        if (await _gameStateService.GetPlayerCount() == 2 && !_gameStateService.GameHasEnded)
        {
            await SendQuestion();
        }

    }


    public async Task AnswerQuestion(Answer answer, long timeTaken)
    {
        bool bothPlayersRegisteredAnswers = await _gameStateService.RegisterAnswer(Context.ConnectionId, answer, timeTaken);
        if(bothPlayersRegisteredAnswers)
        {
            await _gameStateService.ProcessAnswers(Context.ConnectionId);
            await SendQuestion();
        }
    }

    public async Task SendQuestion()
    {
        await _gameStateService.SendQuestion();
    }
}