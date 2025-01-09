using System.ComponentModel.DataAnnotations;
using static QuizSignalR.Infrastructure.Constants.ApplicationConstants.Question;

namespace QuizSignalR.Infrastructure.Models;

public class Question
{
    public Question()
    {
        this.Id = Guid.NewGuid();
        this.Answers = new HashSet<Answer>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(QuestionMaxLength)]
    public string QuestionText { get; set; } = null!;

    [Required]
    public ICollection<Answer> Answers { get; set; }
}