using QuizSignalR.Core.Models;
using QuizSignalR.Infrastructure.Models;
using System.Collections.Concurrent;

namespace QuizSignalR.Core.Contracts
{
    public interface IGameStateService
    {
        Task RegisterPlayers(string contextConnectionId, string playerName);
        Task SendQuestion(GameSession gameSession);
        Task RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken);
        //Task LoadQuestions(int numberOfQuestions);
    }
}
