namespace QuizSignalR.Infrastructure.Models
{
    public class PlayerMessage
    {
        public string Player { get; set; }
        public string Message { get; set; }

        public PlayerMessage(string player, string message)
        {
            Player = player;
            Message = message;
        }
    }
}
