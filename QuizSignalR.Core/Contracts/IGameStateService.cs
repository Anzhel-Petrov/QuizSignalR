using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts
{
    public interface IGameStateService
    {
        // Method to add or update a player's answer
        void AddOrUpdatePlayerAnswer(string playerId, Answer answer, double timeTaken);

        // Method to retrieve all player answers
        Dictionary<string, (Answer answer, double timeTaken)> GetPlayerAnswers();

        // Method to check if all players have answered
        bool HaveAllPlayersAnswered(int expectedPlayerCount);

        // Method to clear all player answers
        void ClearPlayerAnswers();
    }
}
