namespace QuizSignalR.Models;

public class Question
{
    public int Id { get; set; } // Unique identifier
    public string Text { get; set; } = null!;
    public string CorrectAnswer { get; set; } = null!;
    public List<string> Options { get; set; } = new List<string>();
    //Add image or other properties
}