using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Infrastructure.SeedDb;

public class QuestionSeeder
{
    public ICollection<Question> GenerateQuestions()
    {
        return new HashSet<Question>()
        {
            new Question()
            {
                Id = Guid.Parse("3b56d606-b794-43bc-bcf2-a396db01213d"),
                QuestionText = "Кой български възрожденец написва 'История славянобългарска'?"
            },
            new Question()
            {
                Id = Guid.Parse("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                QuestionText = "В кой град е застрелян Васил Левски?"
            },
            new Question()
            {
                Id = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                QuestionText = "Кога е обесен Васил Левски ?"
            },
            new Question()
            {
                Id = Guid.Parse("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                QuestionText = "Какво е било виждането на Васил Левски за начина, по който България трябва да бъде освободена ?"
            },
            new Question()
            {
                Id = Guid.Parse("2225d7e5-d606-49b0-a536-0c34515a9502"),
                QuestionText = "Коя е основната причина за залавянето на Васил Левски ?"
            },
            new Question()
            {
                Id = Guid.Parse("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                QuestionText = "Къде загива Христо Ботев ?"
            },
            new Question()
            {
                Id = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                QuestionText = "Къде е обесен Васил Левски ?"
            },
            new Question()
            {
                Id = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                QuestionText = "Коя от следните клаузи НЕ присъства в договора между България и Византия от 716 г., за който свидетелства Теофан ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Кой български възрожденец е известен със своята поезия и романи, като 'Под игото' ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Кой български възрожденец е известен със своята поезия и романи, като 'Под игото' ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Коя организация Васил Левски създава заедно с други революционери ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Кой е известният вестник, основан от Христо Ботев ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Кой е известният вестник, основан от Христо Ботев ?"
            },
            new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "Какво прави Васил Левски, за да подготви народа за въстание ?"
            }
        };
    }
}