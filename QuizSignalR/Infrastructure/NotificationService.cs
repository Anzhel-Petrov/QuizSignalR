using Microsoft.AspNetCore.SignalR;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Hubs;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Infrastructure;

public class NotificationService : INotificationService
{
    private readonly IHubContext<QuizHub> _hubContext;
    public NotificationService(IHubContext<QuizHub> hubContext)
    {
        this._hubContext = hubContext;
    }

    public async Task SendQuestion(string roomId, Question question)
    {
        //await _hubContext.Clients.All.SendAsync("ReceiveQuestion", question);
        await _hubContext.Clients.Group(roomId).SendAsync("ReceiveQuestion", question);
    }

    public async Task SendMessageToAllClientsAsync<T>(string method, T data)
    {
        await _hubContext.Clients.All.SendAsync(method, data);
    }

    public async Task SendMessageClient<T>(string contextConnectionId, string method, T data)
    {
        await _hubContext.Clients.Client(contextConnectionId).SendAsync(method, data);
    }

    public async Task AddToGroupAsync(string contextConnectionId, string gameId)
    {
        await _hubContext.Groups.AddToGroupAsync(contextConnectionId, gameId);
    }

    public async Task SendMessageGroupAsync<T>(string roomId, string method, T data)
    {
        await _hubContext.Clients.Group(roomId).SendAsync(method, data);
    }
}