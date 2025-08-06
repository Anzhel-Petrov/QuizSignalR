using QuizSignalR.Core.Models;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts
{
    public interface IGameStateService
    {
        Task RegisterPlayers(string contextConnectionId, string playerName);
        Task SendQuestion(GameSession gameSession);
        Task RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken);
        Task Disconnect(string contextConnectionId);
    }
}
