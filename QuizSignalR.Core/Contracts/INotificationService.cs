using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts;

public interface INotificationService
{
    Task SendQuestion(Question question);
    Task SendMessage(string player, string message);
}