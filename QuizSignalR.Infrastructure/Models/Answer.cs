using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static QuizSignalR.Infrastructure.Constants.ApplicationConstants.Answer;

namespace QuizSignalR.Infrastructure.Models;

public class Answer
{
    public Answer()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    public Guid QuestionId { get; set; }

    [Required]
    [MaxLength(AnswerMaxLength)]
    public string AnswerText { get; set; } = null!;

    public bool IsCorrect { get; set; }

    [ForeignKey(nameof(QuestionId))]
    public virtual Question Question { get; set; } = null!;
}