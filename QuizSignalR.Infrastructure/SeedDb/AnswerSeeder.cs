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
                QuestionId = Guid.Parse("b5865ece-b373-4e29-a90b-345fa7841a7d"),
                AnswerText = "В Пловдив",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b5865ece-b373-4e29-a90b-345fa7841a7d"),
                AnswerText = "В Карлово",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b5865ece-b373-4e29-a90b-345fa7841a7d"),
                AnswerText = "Близо до София",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b5865ece-b373-4e29-a90b-345fa7841a7d"),
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
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                AnswerText = "Иван Вазов",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                AnswerText = "Климент Охридски",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                AnswerText = "Йоаким Груев",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                AnswerText = "Васил Левски",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                AnswerText = "В София",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                AnswerText = "В Калофер",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                AnswerText = "В Пловдив",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                AnswerText = "В Русе",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7ff85635-eff0-493d-89fa-af59c287b055"),
                AnswerText = "Български революционен централен комитет",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7ff85635-eff0-493d-89fa-af59c287b055"),
                AnswerText = "Българско възраждане",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7ff85635-eff0-493d-89fa-af59c287b055"),
                AnswerText = "Български учителски съюз",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7ff85635-eff0-493d-89fa-af59c287b055"),
                AnswerText = "Българска православна църква",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                AnswerText = "‘Свобода’",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                AnswerText = "‘Пирин’",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                AnswerText = "‘Знаме’",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                AnswerText = "‘Нов Живот’",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                AnswerText = "Яна и Иван",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                AnswerText = "Мария и Петър",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                AnswerText = "Гина и Иван",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                AnswerText = "Яна и Христо",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("6481fde2-f911-426d-be91-d06d51c8bea3"),
                AnswerText = "Пише стихотворения",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("6481fde2-f911-426d-be91-d06d51c8bea3"),
                AnswerText = "Пътува из страната и създава тайни революционни комитети",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("6481fde2-f911-426d-be91-d06d51c8bea3"),
                AnswerText = "Организира музикални събития",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("6481fde2-f911-426d-be91-d06d51c8bea3"),
                AnswerText = "Строи училища",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                AnswerText = "3 март 1840 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                AnswerText = "18 юли 1837 г.",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                AnswerText = "1 ноември 1850 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                AnswerText = "24 май 1835 г.",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a2e558f9-52ff-4f81-880e-df08729cb403"),
                AnswerText = "Станал е войник",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a2e558f9-52ff-4f81-880e-df08729cb403"),
                AnswerText = "Решил е да стане монах и приема името Игнатий",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a2e558f9-52ff-4f81-880e-df08729cb403"),
                AnswerText = "Станал е търговец",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("a2e558f9-52ff-4f81-880e-df08729cb403"),
                AnswerText = "Отишъл е да живее в чужбина",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("181bcfcc-8552-4630-b5a9-7de966439d56"),
                AnswerText = "Радецки",
                IsCorrect = true
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("181bcfcc-8552-4630-b5a9-7de966439d56"),
                AnswerText = "Дунав",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("181bcfcc-8552-4630-b5a9-7de966439d56"),
                AnswerText = "Шипка",
                IsCorrect = false
            },
            new Answer()
            {
                Id = Guid.NewGuid(),
                QuestionId = Guid.Parse("181bcfcc-8552-4630-b5a9-7de966439d56"),
                AnswerText = "Вола",
                IsCorrect = false
            },
        };
    }
}