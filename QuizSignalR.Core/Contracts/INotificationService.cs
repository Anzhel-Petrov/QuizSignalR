using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts;

public interface INotificationService
{
    Task SendQuestion(Question question);
    Task SendMessageToAllClientsAsync<T> (string method, T data);
    Task SendMessageClient<T>(string contextConnectionId, string method, T data);
}