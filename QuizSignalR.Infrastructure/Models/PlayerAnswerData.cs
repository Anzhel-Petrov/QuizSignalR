namespace QuizSignalR.Infrastructure.Models
{
    public class PlayerAnswerData
    {
        public string PlayerName { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public int Score { get; set; }

        public PlayerAnswerData(string playerName, string answerText, bool isCorrect, int score)
        {
            PlayerName = playerName;
            AnswerText = answerText;
            IsCorrect = isCorrect;
            Score = score;
        }
    }
}
