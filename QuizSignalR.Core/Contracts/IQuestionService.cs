using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Contracts;

public interface IQuestionService
{
    public Task<ICollection<Question>> GetQuestions(int count = 10);
    public Task<Question?> GetRandomQuestion();
}