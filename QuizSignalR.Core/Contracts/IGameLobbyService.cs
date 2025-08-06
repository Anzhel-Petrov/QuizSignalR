using QuizSignalR.Core.Models;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts
{
    public interface IGameLobbyService
    {
        GameSession? GetGameSessionForPlayer(string connectionId);
        void RemoveGame(string gameId);
        Task<AddPlayerResult> TryAddPlayerToGameAsync(Player player);
    }
}
