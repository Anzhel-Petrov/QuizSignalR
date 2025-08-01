using Microsoft.AspNetCore.SignalR;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Hubs;

public class QuizHub : Hub
{
    private readonly IGameStateService _gameStateService;

    public QuizHub(IGameStateService gameStateService)
    {
        this._gameStateService = gameStateService;
    }

    public override async Task OnConnectedAsync()
    {
        //await _gameService.SendMessageClient(Context.ConnectionId, "ReceiveMessage", "Server", "Welcome! Please enter your name.");
        await Clients.Caller.SendAsync("ReceiveMessage", new PlayerMessage("Server", "Welcome! Please enter your name."));
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await _gameStateService.Disconnect(Context.ConnectionId);
        await base.OnDisconnectedAsync(exception);
    }

    public async Task RegisterPlayer(string playerName)
    {
        await _gameStateService.RegisterPlayers(Context.ConnectionId, playerName);
    }

    public async Task AnswerQuestion(Answer answer, long timeTaken)
    {
        await _gameStateService.RegisterAnswer(Context.ConnectionId, answer, timeTaken);
    }
}