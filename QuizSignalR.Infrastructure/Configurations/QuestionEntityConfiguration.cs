using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizSignalR.Infrastructure.Models;
using QuizSignalR.Infrastructure.SeedDb;

namespace QuizSignalR.Infrastructure.Configurations;

public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
{
    private readonly QuestionSeeder _questionSeeder;

    public QuestionEntityConfiguration()
    {
        this._questionSeeder = new QuestionSeeder();
    }
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasData(_questionSeeder.GenerateQuestions());
    }
}