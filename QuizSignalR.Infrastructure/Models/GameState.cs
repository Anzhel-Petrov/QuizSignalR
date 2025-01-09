namespace QuizSignalR.Infrastructure.Models;

public class GameState
{
    public List<Question> Questions { get; set; } = new List<Question>();
    public int CurrentQuestionIndex { get; set; }
    public Dictionary<string, Player> Players { get; set; } = new Dictionary<string, Player>();
    public Question CurrentQuestion => CurrentQuestionIndex < Questions.Count ? Questions[CurrentQuestionIndex] : null;
    public bool GameEnded { get; set; }
}