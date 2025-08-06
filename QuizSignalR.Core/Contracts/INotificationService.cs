using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts
{
    public interface INotificationService
    {
        Task SendQuestion(string roomId, Question question);
        Task SendMessageToAllClientsAsync<T>(string method, T data);
        Task SendMessageClient<T>(string contextConnectionId, string method, T data);
        Task AddToGroupAsync(string contextConnectionId, string gameId);
        Task SendMessageGroupAsync<T>(string roomId, string method, T data);
    }
}

