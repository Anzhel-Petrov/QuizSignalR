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

    public async Task SendQuestion(Question question)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveQuestion", question);
    }

    public async Task SendMessage(string player, string message)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveMessage", player, message);
    }
}