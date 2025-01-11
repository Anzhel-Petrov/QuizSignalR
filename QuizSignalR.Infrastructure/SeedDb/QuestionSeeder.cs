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
                Id = Guid.Parse("b5865ece-b373-4e29-a90b-345fa7841a7d"),
                QuestionText = "Къде е обесен Васил Левски ?"
            },
            new Question()
            {
                Id = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                QuestionText = "Коя от следните клаузи НЕ присъства в договора между България и Византия от 716 г., за който свидетелства Теофан ?"
            },
            new Question()
            {
                Id = Guid.Parse("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                QuestionText = "Кой български възрожденец е известен със своята поезия и романи, като 'Под игото' ?"
            },
            new Question()
            {
                Id = Guid.Parse("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                QuestionText = "Къде е роден Христо Ботев ?"
            },
            new Question()
            {
                Id = Guid.Parse("7ff85635-eff0-493d-89fa-af59c287b055"),
                QuestionText = "Коя организация Васил Левски създава заедно с други революционери ?"
            },
            new Question()
            {
                Id = Guid.Parse("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                QuestionText = "Кой е известният вестник, основан от Христо Ботев ?"
            },
            new Question()
            {
                Id = Guid.Parse("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                QuestionText = "Как се казват родителите на Левски?"
            },
            new Question()
            {
                Id = Guid.Parse("6481fde2-f911-426d-be91-d06d51c8bea3"),
                QuestionText = "Какво прави Васил Левски, за да подготви народа за въстание ?"
            },
            new Question()
            {
                Id = Guid.Parse("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                QuestionText = "Кога е роден Васил Левски ?"
            },
            new Question()
            {
                Id = Guid.Parse("a2e558f9-52ff-4f81-880e-df08729cb403"),
                QuestionText = "Какво е направил Васил Левски, след като е завършил основното си образование ?"
            },
            new Question()
            {
                Id = Guid.Parse("181bcfcc-8552-4630-b5a9-7de966439d56"),
                QuestionText = "Как се казва кораба, с който Ботевата чета стига до България ?"
            }
        };
    }
}