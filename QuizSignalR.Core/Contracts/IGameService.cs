using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts;

public interface IGameService
{
    public Task SendQuestion();
    public Task SendMessageToAllClientsAsync(string method, string player, string message);
    public Task SendMessageToAllClientsAsync(string method, Dictionary<string, Player> currentPlayers);
    public Task SendMessageClient(string contextConnectionId, string method, string player, string message);
}