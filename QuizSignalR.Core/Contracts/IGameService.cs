namespace QuizSignalR.Core.Contracts;

public interface IGameService
{
    public Task SendQuestion();
    public Task SendMessage(string player, string message);
}