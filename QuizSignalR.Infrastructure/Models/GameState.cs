namespace QuizSignalR.Infrastructure.Models;

public class GameState
{
    public GameState()
    {
        this.Questions = new HashSet<Question>();
        this.Players = new Dictionary<string, Player>();
    }
    public ICollection<Question> Questions { get; set; }
    public int CurrentQuestionIndex { get; set; }
    public Dictionary<string, Player> Players { get; set; }
    public Question CurrentQuestion { get; set; }
    public bool GameEnded { get; set; }
}