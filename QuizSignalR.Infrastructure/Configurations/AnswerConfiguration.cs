using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizSignalR.Infrastructure.Models;
using QuizSignalR.Infrastructure.SeedDb;
using static QuizSignalR.Infrastructure.Constants.ApplicationConstants.Answer;

namespace QuizSignalR.Infrastructure.Configurations;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    private readonly AnswerSeeder _answerSeeder;

    public AnswerConfiguration()
    {
        this._answerSeeder = new AnswerSeeder();
    }
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder
            .HasIndex(a => new { a.QuestionId, a.IsCorrect })
            .IsUnique()
            .HasFilter(OneCorrectAnswer);

        builder.HasData(_answerSeeder.GenerateAnswers());
    }
}