using System.Numerics;
using System.Text.Json;
using QuizSignalR.Core.Contracts;
using QuizSignalR.Infrastructure.Models;

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
        //var questions = await _questionService.GetQuestions();
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

    public async Task SendMessageToAllClientsAsync(string method, string player, string message)
    {
        await _notificationService.SendMessageToAllClientsAsync(method, new PlayerMessage(player, message));
    }

    public async Task SendMessageToAllClientsAsync(string method, Dictionary<string, Player> currentPlayers)
    {
        await _notificationService.SendMessageToAllClientsAsync( method, currentPlayers);
    }

    public async Task SendMessageClient(string contextConnectionId, string method, string player, string message)
    {
        await _notificationService.SendMessageClient(contextConnectionId, method, new PlayerMessage(player, message));
    }
}