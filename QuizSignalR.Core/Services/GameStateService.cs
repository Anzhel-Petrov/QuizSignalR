using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Services
{
    public class GameStateService : IGameStateService
    {
        private readonly Dictionary<string, (Answer, double)> _playersAnswers = new Dictionary<string, (Answer, double)>();

        public void AddOrUpdatePlayerAnswer(string playerId, Answer answer, double timeTaken)
        {
            _playersAnswers[playerId] = (answer, timeTaken);
        }

        public void ClearPlayerAnswers()
        {
            _playersAnswers.Clear();
        }

        public Dictionary<string, (Answer answer, double timeTaken)> GetPlayerAnswers()
        {
            return _playersAnswers;
        }

        public bool HaveAllPlayersAnswered(int expectedPlayerCount)
        {
            return _playersAnswers.Count == expectedPlayerCount;
        }
    }
}
