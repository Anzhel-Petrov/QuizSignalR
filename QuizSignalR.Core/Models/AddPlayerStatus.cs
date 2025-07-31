namespace QuizSignalR.Core.Models
{
    public enum AddPlayerResultStatus 
    { 
        Success,
        NameTaken,
        GameFull,
        AlreadyRegisteredInGame,
        EmptyName
    }
}
