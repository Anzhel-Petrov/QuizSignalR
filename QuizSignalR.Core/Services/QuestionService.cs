using Microsoft.EntityFrameworkCore;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure;
using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Core.Services;

public class QuestionService : IQuestionService
{
    private readonly QuizDbContext _context;
    private readonly HashSet<Guid> _askedQuestions = new HashSet<Guid>();

    public QuestionService(QuizDbContext context)
    {
        this._context = context;
    }

    public async Task<ICollection<Question>>LoadRandomQuestions(int count = 10)
    {
        return await _context.Questions
            .Include(q => q.Answers)
            .OrderBy(q => Guid.NewGuid())
            .Take(count)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Question?> GetRandomQuestion()
    {
        while (_askedQuestions.Count != 10)
        {
            var question = await _context.Questions
                .Include(q => q.Answers)
                .Where(q => !_askedQuestions.Contains(q.Id))
                .OrderBy(q => Guid.NewGuid())
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (question != null)
            {
                _askedQuestions.Add(question.Id);
            }

            return question;
        }

        return null;
    }
}