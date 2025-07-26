using QuizSignalR.Infrastructure.Models;
using System.Collections.Concurrent;

namespace QuizSignalR.Core.Contracts
{
    public interface IGameStateService
    {
        bool GameHasEnded { get; set; }
        ICollection<Question> Questions { get; set; }
        bool HaveAllPlayersAnswered();
        Task RegisterPlayers(string contextConnectionId, string playerName);
        Task SendQuestion();
        Task ProcessAnswers(string contextConnectionId);
        Task<int> GetPlayerCount();
        ICollection<Player> GetPlayers();
        Task<bool> RegisterAnswer(string contextConnectionId, Answer answer, double timeTaken);
        Task LoadQuestions(int numberOfQuestions);
        int GetQuestionsCount();
    }
}
