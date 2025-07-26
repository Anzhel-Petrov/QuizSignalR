using QuizSignalR.Infrastructure.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSignalR.Core.Models
{
    public class GameStateContainer
    {
        public ConcurrentDictionary<string, Player> Players { get; } = new();
        public ConcurrentDictionary<string, (Player, Answer, double)> PlayersAnswers { get; } = new();
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();
        public bool GameHasEnded { get; set; } = false;
        public int CurrentQuestionIndex { get; set; }
    }
}
