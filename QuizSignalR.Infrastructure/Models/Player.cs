using QuizSignalR.Infrastructure.Models.Enums;

namespace QuizSignalR.Infrastructure.Models;

public class Player
{
    public Player()
    {
        this.Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string ConnectionId { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public int Score { get; set; }
    public PlayerStatus Status { get; set; } = PlayerStatus.Active;
}