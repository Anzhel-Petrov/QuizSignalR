using QuizSignalR.Infrastructure.Models;
using System.Collections.Concurrent;

namespace QuizSignalR.Core.Models
{
    public class GameSession
    {
        public ConcurrentDictionary<string, Player> Players { get; } = new();
        public ConcurrentDictionary<string, (Player, Answer, double)> PlayersAnswers { get; } = new();
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();
        public bool GameHasEnded { get; set; } = false;
        public int CurrentQuestionIndex { get; set; }
        public string GameId { get; } = Guid.NewGuid().ToString();
        public bool IsFull => Players.Count == 2;
        public int NextQuestionIndex => CurrentQuestionIndex++;
    }
}
