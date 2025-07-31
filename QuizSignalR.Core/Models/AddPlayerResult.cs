namespace QuizSignalR.Core.Models
{
    public class AddPlayerResult
    {
        public GameSession? GameSession { get; set; }
        public AddPlayerResultStatus Status { get; set; }
    }
}
