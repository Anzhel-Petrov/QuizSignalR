using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts;

public interface IQuestionService
{
    public Task<ICollection<Question>> LoadRandomQuestions(int count = 10);
    public Task<Question?> GetRandomQuestion();
}