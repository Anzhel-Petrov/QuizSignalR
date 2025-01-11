namespace QuizSignalR.Infrastructure.Constants;

public static class ApplicationConstants
{
    public static class Answer
    {
        public const int AnswerMaxLength = 500;
        public const string OneCorrectAnswer = "[IsCorrect] = 1";
    }

    public static class Question
    {
        public const int QuestionMaxLength = 500;
    }
}