using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizSignalR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestionsWithAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText" },
                values: new object[,]
                {
                    { new Guid("181bcfcc-8552-4630-b5a9-7de966439d56"), "Как се казва кораба, с който Ботевата чета стига до България ?" },
                    { new Guid("2225d7e5-d606-49b0-a536-0c34515a9502"), "Коя е основната причина за залавянето на Васил Левски ?" },
                    { new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9"), "Какво е било виждането на Васил Левски за начина, по който България трябва да бъде освободена ?" },
                    { new Guid("3b56d606-b794-43bc-bcf2-a396db01213d"), "Кой български възрожденец написва 'История славянобългарска'?" },
                    { new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"), "Как се казват родителите на Левски?" },
                    { new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32"), "Коя от следните клаузи НЕ присъства в договора между България и Византия от 716 г., за който свидетелства Теофан ?" },
                    { new Guid("6481fde2-f911-426d-be91-d06d51c8bea3"), "Какво прави Васил Левски, за да подготви народа за въстание ?" },
                    { new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266"), "Кога е роден Васил Левски ?" },
                    { new Guid("7ff85635-eff0-493d-89fa-af59c287b055"), "Коя организация Васил Левски създава заедно с други революционери ?" },
                    { new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"), "Къде е роден Христо Ботев ?" },
                    { new Guid("a2e558f9-52ff-4f81-880e-df08729cb403"), "Какво е направил Васил Левски, след като е завършил основното си образование ?" },
                    { new Guid("a5324881-7b48-4b08-88e8-108b74040815"), "Кога е обесен Васил Левски ?" },
                    { new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062"), "Кой е известният вестник, основан от Христо Ботев ?" },
                    { new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d"), "Къде е обесен Васил Левски ?" },
                    { new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6"), "Къде загива Христо Ботев ?" },
                    { new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf"), "Кой български възрожденец е известен със своята поезия и романи, като 'Под игото' ?" },
                    { new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394"), "В кой град е застрелян Васил Левски?" }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("01f036b3-bf61-48a4-ba7e-6fe48b17726b"), "Дунав", false, new Guid("181bcfcc-8552-4630-b5a9-7de966439d56") },
                    { new Guid("0299dfe1-8380-47dc-9214-fe19431652c7"), "‘Свобода’", false, new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062") },
                    { new Guid("0762d864-f113-4999-bb00-4c0cda0d118b"), "Български учителски съюз", false, new Guid("7ff85635-eff0-493d-89fa-af59c287b055") },
                    { new Guid("12f718f4-9263-4332-8f68-691d66de21dd"), "Българската граница с империята вече достига Милеопа в Тракия", false, new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32") },
                    { new Guid("1738934d-b184-4e21-8f3b-65120d07b8af"), "Станал е войник", false, new Guid("a2e558f9-52ff-4f81-880e-df08729cb403") },
                    { new Guid("180730b4-26ca-4130-b51e-6dde95147d20"), "18 юли 1837 г.", true, new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266") },
                    { new Guid("21fc2736-5d99-429f-8467-ff4d9a09d457"), "Българско възраждане", false, new Guid("7ff85635-eff0-493d-89fa-af59c287b055") },
                    { new Guid("235c7695-a587-40d2-9f69-db81f6622fab"), "Отишъл е да живее в чужбина", false, new Guid("a2e558f9-52ff-4f81-880e-df08729cb403") },
                    { new Guid("23ffbaae-988c-4572-8115-ba3f07c40bca"), "Византия се задължава да плаща годишен данък на България", false, new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32") },
                    { new Guid("28b58422-a6d9-4491-927a-14fbf91d9c2a"), "Шипка", false, new Guid("181bcfcc-8552-4630-b5a9-7de966439d56") },
                    { new Guid("2b70b9cc-4778-48ac-9a53-04391011c8f9"), "Не е застрелян", true, new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394") },
                    { new Guid("2fbf7dee-70bb-458d-a521-d8e4eb264d64"), "С помощта на чужди държави", false, new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9") },
                    { new Guid("3445f70f-7694-4fd9-934a-2d8752a86bdb"), "В Пловдив", false, new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6") },
                    { new Guid("34f0e947-b8b9-46a6-92a5-0ff94587887d"), "В Русе", false, new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce") },
                    { new Guid("39d5ccd1-660a-460a-9f59-27e239d63977"), "Пътува из страната и създава тайни революционни комитети", true, new Guid("6481fde2-f911-426d-be91-d06d51c8bea3") },
                    { new Guid("3d9f0d35-2ed2-476f-8497-9a237a8f4372"), "Строи училища", false, new Guid("6481fde2-f911-426d-be91-d06d51c8bea3") },
                    { new Guid("3df6583f-9237-4932-8849-ffa61ba0a70a"), "Гео Милев", false, new Guid("3b56d606-b794-43bc-bcf2-a396db01213d") },
                    { new Guid("3efe1592-b8c3-48d4-9325-65f841670abe"), "Близо до София", true, new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d") },
                    { new Guid("40ddfcbc-5cb8-4450-8ca6-a1e2732e4a06"), "1 ноември 1850 г.", false, new Guid("a5324881-7b48-4b08-88e8-108b74040815") },
                    { new Guid("4836c25e-111e-4ade-bdaa-d4ade7d58c43"), "3 март 1840 г.", false, new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266") },
                    { new Guid("4c31e867-46f4-46ce-a9d8-7278ee07a8c4"), "Йоаким Груев", false, new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf") },
                    { new Guid("4fe6729c-e48f-4229-8354-0bf8d82cc6b3"), "В Карлово", false, new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394") },
                    { new Guid("517396c5-fa8e-4345-8c45-a24a7408d000"), "В София", false, new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6") },
                    { new Guid("524d196c-34d4-45fb-9fc9-6c9b57f95331"), "Вола", false, new Guid("181bcfcc-8552-4630-b5a9-7de966439d56") },
                    { new Guid("59129569-628d-4af2-905a-77b23e52b05c"), "Васил Левски", false, new Guid("3b56d606-b794-43bc-bcf2-a396db01213d") },
                    { new Guid("5c008254-4435-4677-85bd-7244356d84db"), "‘Знаме’", true, new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062") },
                    { new Guid("5c0a12b8-42df-4ae2-90b1-7a742b10536c"), "В Търново", false, new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d") },
                    { new Guid("669da5f0-8c01-4160-8165-75e582c992e4"), "Паисий Хилендарски", true, new Guid("3b56d606-b794-43bc-bcf2-a396db01213d") },
                    { new Guid("669db3c8-4b54-44a7-acf1-d1d34bac6455"), "България се задължава да пропуска византийската армия да преминава през нейната територия", true, new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32") },
                    { new Guid("6768e407-0d77-4321-8af6-0da53f6adf50"), "На връх Шипка", false, new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6") },
                    { new Guid("68ecdac4-4360-476f-83c5-14ca6f446baa"), "Предателство", true, new Guid("2225d7e5-d606-49b0-a536-0c34515a9502") },
                    { new Guid("7006afe3-257e-4486-ac70-ca658cc6a041"), "Климент Охридски", false, new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf") },
                    { new Guid("73875a76-83ba-4f02-a6c6-19a0ce3b3033"), "Търговците от двете страни трябва да бъдат упълномощавани с грамоти, снабдени с печати", false, new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32") },
                    { new Guid("7640beb8-bad6-4dbe-8833-0124ecb07b80"), "Пише стихотворения", false, new Guid("6481fde2-f911-426d-be91-d06d51c8bea3") },
                    { new Guid("770361ca-c614-40da-b5df-78b88185f675"), "Организира музикални събития", false, new Guid("6481fde2-f911-426d-be91-d06d51c8bea3") },
                    { new Guid("790e3dec-cd55-4230-8751-347d02a5a71e"), "Чрез подкрепа от съседни държави", false, new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9") },
                    { new Guid("82271255-ba37-4cfa-add2-494b983be928"), "24 май 1835 г.", false, new Guid("a5324881-7b48-4b08-88e8-108b74040815") },
                    { new Guid("83b0d644-85fb-48c3-9153-90da5bca828d"), "В Пловдив", false, new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d") },
                    { new Guid("842c71c2-c554-4ed4-b329-759abee2e897"), "В Пловдив", false, new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce") },
                    { new Guid("8b7845b3-fe34-4512-908e-3c0ba431a3ac"), "3 март 1840 г.", false, new Guid("a5324881-7b48-4b08-88e8-108b74040815") },
                    { new Guid("8d31ad23-2c0a-43a6-99ba-64d0d6583bb4"), "‘Нов Живот’", false, new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062") },
                    { new Guid("9251c4ed-6615-49da-9017-a60f753346ab"), "Чрез мирни преговори", false, new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9") },
                    { new Guid("947a7338-3502-4c20-b100-b50dea9a79c1"), "Български революционен централен комитет", true, new Guid("7ff85635-eff0-493d-89fa-af59c287b055") },
                    { new Guid("9a301e2a-e360-4cdb-9590-e8865575d0e1"), "Болест", false, new Guid("2225d7e5-d606-49b0-a536-0c34515a9502") },
                    { new Guid("9db826d4-c0bb-48b7-bb90-5d8c65b68fb3"), "Изчерпване на ресурсите", false, new Guid("2225d7e5-d606-49b0-a536-0c34515a9502") },
                    { new Guid("a0999a7c-346b-4983-9716-4d6fe0dea982"), "Иван Вазов", false, new Guid("3b56d606-b794-43bc-bcf2-a396db01213d") },
                    { new Guid("a3e0a3ad-b807-480a-881b-3ab517205451"), "24 май 1835 г.", false, new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266") },
                    { new Guid("adf170ce-0296-41fa-a75e-ee821996d8cf"), "‘Пирин’", false, new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062") },
                    { new Guid("ae4a0ce4-a660-47d1-960a-5204de2c9dcd"), "Близо до София", false, new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394") },
                    { new Guid("aedd01c8-6ef6-449d-88ec-782f97d10a1b"), "Радецки", true, new Guid("181bcfcc-8552-4630-b5a9-7de966439d56") },
                    { new Guid("b01445ab-91e3-41b8-bf25-261e91d99327"), "На връх Вола", true, new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6") },
                    { new Guid("b1a71edc-e238-4b40-a0f9-fc473cf81cfd"), "Васил Левски", false, new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf") },
                    { new Guid("b425c26e-249c-4469-b192-f2f83385111d"), "Яна и Христо", false, new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1") },
                    { new Guid("b8a6fdee-bdf8-4fb7-835b-faccd172a559"), "Станал е търговец", false, new Guid("a2e558f9-52ff-4f81-880e-df08729cb403") },
                    { new Guid("b9b41a63-4118-4d58-af73-e876dfc2abb8"), "В София", false, new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce") },
                    { new Guid("ba196d92-6d4a-496d-aee3-e196d9060305"), "Гина и Иван", true, new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1") },
                    { new Guid("dcbf4cf5-af3a-431a-a6fe-ea7070172820"), "В Пловдив", false, new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394") },
                    { new Guid("df81bc53-94db-4bde-9caa-a0f5e85e2ad3"), "Решил е да стане монах и приема името Игнатий", true, new Guid("a2e558f9-52ff-4f81-880e-df08729cb403") },
                    { new Guid("e82074de-4cff-4f21-9139-82ef280f804f"), "В Калофер", true, new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce") },
                    { new Guid("e8b951b0-77d6-4284-9e7c-695f92cf75a3"), "Само българите трябва да се борят за своята свобод", true, new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9") },
                    { new Guid("eff4fc21-8539-4e30-aa03-a292d641c4e2"), "1 ноември 1850 г.", false, new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266") },
                    { new Guid("f0a30740-a3c2-4f84-ad78-9487fded27df"), "18 юли 1837 г.", true, new Guid("a5324881-7b48-4b08-88e8-108b74040815") },
                    { new Guid("f45a4979-eb4f-40dd-9b2f-d576214132af"), "Българска православна църква", false, new Guid("7ff85635-eff0-493d-89fa-af59c287b055") },
                    { new Guid("f8ae7b9f-27f1-4a25-a557-5e8bde288845"), "Яна и Иван", false, new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1") },
                    { new Guid("f9300e45-a418-4642-a9bd-2692033bd6f2"), "Иван Вазов", true, new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf") },
                    { new Guid("f9c4a482-5b6a-496d-9716-ed804e05d3ba"), "Лошо време", false, new Guid("2225d7e5-d606-49b0-a536-0c34515a9502") },
                    { new Guid("fc143aef-61b2-4f8b-a64e-e96598b51547"), "В Карлово", false, new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d") },
                    { new Guid("fff7bcbe-5b23-4923-b261-73dfcdf0b18b"), "Мария и Петър", false, new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId_IsCorrect",
                table: "Answer",
                columns: new[] { "QuestionId", "IsCorrect" },
                unique: true,
                filter: "[IsCorrect] = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId_IsCorrect",
                table: "Answer");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("01f036b3-bf61-48a4-ba7e-6fe48b17726b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0299dfe1-8380-47dc-9214-fe19431652c7"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0762d864-f113-4999-bb00-4c0cda0d118b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("12f718f4-9263-4332-8f68-691d66de21dd"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("1738934d-b184-4e21-8f3b-65120d07b8af"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("180730b4-26ca-4130-b51e-6dde95147d20"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("21fc2736-5d99-429f-8467-ff4d9a09d457"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("235c7695-a587-40d2-9f69-db81f6622fab"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("23ffbaae-988c-4572-8115-ba3f07c40bca"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("28b58422-a6d9-4491-927a-14fbf91d9c2a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2b70b9cc-4778-48ac-9a53-04391011c8f9"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2fbf7dee-70bb-458d-a521-d8e4eb264d64"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3445f70f-7694-4fd9-934a-2d8752a86bdb"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("34f0e947-b8b9-46a6-92a5-0ff94587887d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("39d5ccd1-660a-460a-9f59-27e239d63977"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3d9f0d35-2ed2-476f-8497-9a237a8f4372"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3df6583f-9237-4932-8849-ffa61ba0a70a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3efe1592-b8c3-48d4-9325-65f841670abe"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("40ddfcbc-5cb8-4450-8ca6-a1e2732e4a06"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4836c25e-111e-4ade-bdaa-d4ade7d58c43"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4c31e867-46f4-46ce-a9d8-7278ee07a8c4"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4fe6729c-e48f-4229-8354-0bf8d82cc6b3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("517396c5-fa8e-4345-8c45-a24a7408d000"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("524d196c-34d4-45fb-9fc9-6c9b57f95331"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("59129569-628d-4af2-905a-77b23e52b05c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5c008254-4435-4677-85bd-7244356d84db"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5c0a12b8-42df-4ae2-90b1-7a742b10536c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("669da5f0-8c01-4160-8165-75e582c992e4"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("669db3c8-4b54-44a7-acf1-d1d34bac6455"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6768e407-0d77-4321-8af6-0da53f6adf50"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("68ecdac4-4360-476f-83c5-14ca6f446baa"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7006afe3-257e-4486-ac70-ca658cc6a041"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("73875a76-83ba-4f02-a6c6-19a0ce3b3033"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7640beb8-bad6-4dbe-8833-0124ecb07b80"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("770361ca-c614-40da-b5df-78b88185f675"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("790e3dec-cd55-4230-8751-347d02a5a71e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("82271255-ba37-4cfa-add2-494b983be928"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("83b0d644-85fb-48c3-9153-90da5bca828d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("842c71c2-c554-4ed4-b329-759abee2e897"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("8b7845b3-fe34-4512-908e-3c0ba431a3ac"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("8d31ad23-2c0a-43a6-99ba-64d0d6583bb4"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("9251c4ed-6615-49da-9017-a60f753346ab"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("947a7338-3502-4c20-b100-b50dea9a79c1"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("9a301e2a-e360-4cdb-9590-e8865575d0e1"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("9db826d4-c0bb-48b7-bb90-5d8c65b68fb3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a0999a7c-346b-4983-9716-4d6fe0dea982"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a3e0a3ad-b807-480a-881b-3ab517205451"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("adf170ce-0296-41fa-a75e-ee821996d8cf"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ae4a0ce4-a660-47d1-960a-5204de2c9dcd"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("aedd01c8-6ef6-449d-88ec-782f97d10a1b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b01445ab-91e3-41b8-bf25-261e91d99327"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b1a71edc-e238-4b40-a0f9-fc473cf81cfd"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b425c26e-249c-4469-b192-f2f83385111d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b8a6fdee-bdf8-4fb7-835b-faccd172a559"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b9b41a63-4118-4d58-af73-e876dfc2abb8"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ba196d92-6d4a-496d-aee3-e196d9060305"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("dcbf4cf5-af3a-431a-a6fe-ea7070172820"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("df81bc53-94db-4bde-9caa-a0f5e85e2ad3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("e82074de-4cff-4f21-9139-82ef280f804f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("e8b951b0-77d6-4284-9e7c-695f92cf75a3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("eff4fc21-8539-4e30-aa03-a292d641c4e2"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f0a30740-a3c2-4f84-ad78-9487fded27df"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f45a4979-eb4f-40dd-9b2f-d576214132af"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f8ae7b9f-27f1-4a25-a557-5e8bde288845"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f9300e45-a418-4642-a9bd-2692033bd6f2"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f9c4a482-5b6a-496d-9716-ed804e05d3ba"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("fc143aef-61b2-4f8b-a64e-e96598b51547"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("fff7bcbe-5b23-4923-b261-73dfcdf0b18b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("181bcfcc-8552-4630-b5a9-7de966439d56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2225d7e5-d606-49b0-a536-0c34515a9502"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b56d606-b794-43bc-bcf2-a396db01213d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6481fde2-f911-426d-be91-d06d51c8bea3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7ff85635-eff0-493d-89fa-af59c287b055"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a2e558f9-52ff-4f81-880e-df08729cb403"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a5324881-7b48-4b08-88e8-108b74040815"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394"));

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");
        }
    }
}
