using QuizSignalR.Infrastructure.Models;

namespace QuizSignalR.Infrastructure.SeedDb;

public class AnswerSeeder
{
    public ICollection<Answer> GenerateAnswers()
    {
        return new HashSet<Answer>()
        {
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3b56d606-b794-43bc-bcf2-a396db01213d"),
                AnswerText = "Иван Вазов",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3b56d606-b794-43bc-bcf2-a396db01213d"),
                AnswerText = "Паисий Хилендарски",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3b56d606-b794-43bc-bcf2-a396db01213d"),
                AnswerText = "Гео Милев",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3b56d606-b794-43bc-bcf2-a396db01213d"),
                AnswerText = "Васил Левски",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                AnswerText = "В Пловдив",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                AnswerText = "В Карлово",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                AnswerText = "Близо до София",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                AnswerText = "Не е застрелян",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "3 март 1840 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "18 юли 1837 г.",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "1 ноември 1850 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "24 май 1835 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                AnswerText = "С помощта на чужди държави",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                AnswerText = "Чрез мирни преговори",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                AnswerText = "Само българите трябва да се борят за своята свобод",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                AnswerText = "Чрез подкрепа от съседни държави",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2225d7e5-d606-49b0-a536-0c34515a9502"),
                AnswerText = "Предателство",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2225d7e5-d606-49b0-a536-0c34515a9502"),
                AnswerText = "Болест",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2225d7e5-d606-49b0-a536-0c34515a9502"),
                AnswerText = "Лошо време",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("2225d7e5-d606-49b0-a536-0c34515a9502"),
                AnswerText = "Изчерпване на ресурсите",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                AnswerText = "В София",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                AnswerText = "На връх Вола",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                AnswerText = "В Пловдив",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                AnswerText = "На връх Шипка",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "В Пловдив",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "В Карлово",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "Близо до София",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a5324881-7b48-4b08-88e8-108b74040815"),
                AnswerText = "В Търново",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                AnswerText = "Византия се задължава да плаща годишен данък на България",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                AnswerText = "Българската граница с империята вече достига Милеопа в Тракия",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                AnswerText = "България се задължава да пропуска византийската армия да преминава през нейната територия",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                AnswerText = "Търговците от двете страни трябва да бъдат упълномощавани с грамоти, снабдени с печати",
                IsCorrect = false
            },
        };
    }
}