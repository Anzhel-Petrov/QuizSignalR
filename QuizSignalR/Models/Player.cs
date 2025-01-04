namespace QuizSignalR.Models;

public class Player
{
    public string ConnectionId { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public int Score { get; set; }
}