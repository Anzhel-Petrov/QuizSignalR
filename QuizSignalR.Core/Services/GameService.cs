using System.Text.Json;
using QuizSignalR.Core.Contracts;

namespace QuizSignalR.Core.Services;

public class GameService : IGameService
{
    private readonly INotificationService _notificationService;
    private readonly IQuestionService _questionService;

    public GameService(INotificationService notificationService, IQuestionService questionService)
    {
        this._notificationService = notificationService;
        this._questionService = questionService;
    }

    public async Task SendQuestion()
    {
        var randomQuestion = await _questionService.GetRandomQuestion();
        //if (randomQuestion.Answers.Any(a => a.Question == randomQuestion))
        //{
        //    Console.WriteLine("Circular reference detected!");
        //}
        //var jsonQuestionConvert = JsonSerializer.Serialize(randomQuestion);
        //var jsonQuestionConvert = JsonSerializer.Serialize(randomQuestion, new JsonSerializerOptions
        //{
        //    ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles,
        //    WriteIndented = true
        //});
        await _notificationService.SendQuestion(randomQuestion);
    }

    public async Task SendMessage(string player, string message)
    {
        await _notificationService.SendMessage(player, message);
    }
}