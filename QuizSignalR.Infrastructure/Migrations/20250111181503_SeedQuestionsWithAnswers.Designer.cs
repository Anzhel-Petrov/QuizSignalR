﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizSignalR.Infrastructure;

#nullable disable

namespace QuizSignalR.Infrastructure.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    [Migration("20250111181503_SeedQuestionsWithAnswers")]
    partial class SeedQuestionsWithAnswers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizSignalR.Infrastructure.Models.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId", "IsCorrect")
                        .IsUnique()
                        .HasFilter("[IsCorrect] = 1");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0999a7c-346b-4983-9716-4d6fe0dea982"),
                            AnswerText = "Иван Вазов",
                            IsCorrect = false,
                            QuestionId = new Guid("3b56d606-b794-43bc-bcf2-a396db01213d")
                        },
                        new
                        {
                            Id = new Guid("669da5f0-8c01-4160-8165-75e582c992e4"),
                            AnswerText = "Паисий Хилендарски",
                            IsCorrect = true,
                            QuestionId = new Guid("3b56d606-b794-43bc-bcf2-a396db01213d")
                        },
                        new
                        {
                            Id = new Guid("3df6583f-9237-4932-8849-ffa61ba0a70a"),
                            AnswerText = "Гео Милев",
                            IsCorrect = false,
                            QuestionId = new Guid("3b56d606-b794-43bc-bcf2-a396db01213d")
                        },
                        new
                        {
                            Id = new Guid("59129569-628d-4af2-905a-77b23e52b05c"),
                            AnswerText = "Васил Левски",
                            IsCorrect = false,
                            QuestionId = new Guid("3b56d606-b794-43bc-bcf2-a396db01213d")
                        },
                        new
                        {
                            Id = new Guid("dcbf4cf5-af3a-431a-a6fe-ea7070172820"),
                            AnswerText = "В Пловдив",
                            IsCorrect = false,
                            QuestionId = new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394")
                        },
                        new
                        {
                            Id = new Guid("4fe6729c-e48f-4229-8354-0bf8d82cc6b3"),
                            AnswerText = "В Карлово",
                            IsCorrect = false,
                            QuestionId = new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394")
                        },
                        new
                        {
                            Id = new Guid("ae4a0ce4-a660-47d1-960a-5204de2c9dcd"),
                            AnswerText = "Близо до София",
                            IsCorrect = false,
                            QuestionId = new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394")
                        },
                        new
                        {
                            Id = new Guid("2b70b9cc-4778-48ac-9a53-04391011c8f9"),
                            AnswerText = "Не е застрелян",
                            IsCorrect = true,
                            QuestionId = new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394")
                        },
                        new
                        {
                            Id = new Guid("8b7845b3-fe34-4512-908e-3c0ba431a3ac"),
                            AnswerText = "3 март 1840 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("a5324881-7b48-4b08-88e8-108b74040815")
                        },
                        new
                        {
                            Id = new Guid("f0a30740-a3c2-4f84-ad78-9487fded27df"),
                            AnswerText = "18 юли 1837 г.",
                            IsCorrect = true,
                            QuestionId = new Guid("a5324881-7b48-4b08-88e8-108b74040815")
                        },
                        new
                        {
                            Id = new Guid("40ddfcbc-5cb8-4450-8ca6-a1e2732e4a06"),
                            AnswerText = "1 ноември 1850 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("a5324881-7b48-4b08-88e8-108b74040815")
                        },
                        new
                        {
                            Id = new Guid("82271255-ba37-4cfa-add2-494b983be928"),
                            AnswerText = "24 май 1835 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("a5324881-7b48-4b08-88e8-108b74040815")
                        },
                        new
                        {
                            Id = new Guid("2fbf7dee-70bb-458d-a521-d8e4eb264d64"),
                            AnswerText = "С помощта на чужди държави",
                            IsCorrect = false,
                            QuestionId = new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9")
                        },
                        new
                        {
                            Id = new Guid("9251c4ed-6615-49da-9017-a60f753346ab"),
                            AnswerText = "Чрез мирни преговори",
                            IsCorrect = false,
                            QuestionId = new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9")
                        },
                        new
                        {
                            Id = new Guid("e8b951b0-77d6-4284-9e7c-695f92cf75a3"),
                            AnswerText = "Само българите трябва да се борят за своята свобод",
                            IsCorrect = true,
                            QuestionId = new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9")
                        },
                        new
                        {
                            Id = new Guid("790e3dec-cd55-4230-8751-347d02a5a71e"),
                            AnswerText = "Чрез подкрепа от съседни държави",
                            IsCorrect = false,
                            QuestionId = new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9")
                        },
                        new
                        {
                            Id = new Guid("68ecdac4-4360-476f-83c5-14ca6f446baa"),
                            AnswerText = "Предателство",
                            IsCorrect = true,
                            QuestionId = new Guid("2225d7e5-d606-49b0-a536-0c34515a9502")
                        },
                        new
                        {
                            Id = new Guid("9a301e2a-e360-4cdb-9590-e8865575d0e1"),
                            AnswerText = "Болест",
                            IsCorrect = false,
                            QuestionId = new Guid("2225d7e5-d606-49b0-a536-0c34515a9502")
                        },
                        new
                        {
                            Id = new Guid("f9c4a482-5b6a-496d-9716-ed804e05d3ba"),
                            AnswerText = "Лошо време",
                            IsCorrect = false,
                            QuestionId = new Guid("2225d7e5-d606-49b0-a536-0c34515a9502")
                        },
                        new
                        {
                            Id = new Guid("9db826d4-c0bb-48b7-bb90-5d8c65b68fb3"),
                            AnswerText = "Изчерпване на ресурсите",
                            IsCorrect = false,
                            QuestionId = new Guid("2225d7e5-d606-49b0-a536-0c34515a9502")
                        },
                        new
                        {
                            Id = new Guid("517396c5-fa8e-4345-8c45-a24a7408d000"),
                            AnswerText = "В София",
                            IsCorrect = false,
                            QuestionId = new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6")
                        },
                        new
                        {
                            Id = new Guid("b01445ab-91e3-41b8-bf25-261e91d99327"),
                            AnswerText = "На връх Вола",
                            IsCorrect = true,
                            QuestionId = new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6")
                        },
                        new
                        {
                            Id = new Guid("3445f70f-7694-4fd9-934a-2d8752a86bdb"),
                            AnswerText = "В Пловдив",
                            IsCorrect = false,
                            QuestionId = new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6")
                        },
                        new
                        {
                            Id = new Guid("6768e407-0d77-4321-8af6-0da53f6adf50"),
                            AnswerText = "На връх Шипка",
                            IsCorrect = false,
                            QuestionId = new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6")
                        },
                        new
                        {
                            Id = new Guid("83b0d644-85fb-48c3-9153-90da5bca828d"),
                            AnswerText = "В Пловдив",
                            IsCorrect = false,
                            QuestionId = new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d")
                        },
                        new
                        {
                            Id = new Guid("fc143aef-61b2-4f8b-a64e-e96598b51547"),
                            AnswerText = "В Карлово",
                            IsCorrect = false,
                            QuestionId = new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d")
                        },
                        new
                        {
                            Id = new Guid("3efe1592-b8c3-48d4-9325-65f841670abe"),
                            AnswerText = "Близо до София",
                            IsCorrect = true,
                            QuestionId = new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d")
                        },
                        new
                        {
                            Id = new Guid("5c0a12b8-42df-4ae2-90b1-7a742b10536c"),
                            AnswerText = "В Търново",
                            IsCorrect = false,
                            QuestionId = new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d")
                        },
                        new
                        {
                            Id = new Guid("23ffbaae-988c-4572-8115-ba3f07c40bca"),
                            AnswerText = "Византия се задължава да плаща годишен данък на България",
                            IsCorrect = false,
                            QuestionId = new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32")
                        },
                        new
                        {
                            Id = new Guid("12f718f4-9263-4332-8f68-691d66de21dd"),
                            AnswerText = "Българската граница с империята вече достига Милеопа в Тракия",
                            IsCorrect = false,
                            QuestionId = new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32")
                        },
                        new
                        {
                            Id = new Guid("669db3c8-4b54-44a7-acf1-d1d34bac6455"),
                            AnswerText = "България се задължава да пропуска византийската армия да преминава през нейната територия",
                            IsCorrect = true,
                            QuestionId = new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32")
                        },
                        new
                        {
                            Id = new Guid("73875a76-83ba-4f02-a6c6-19a0ce3b3033"),
                            AnswerText = "Търговците от двете страни трябва да бъдат упълномощавани с грамоти, снабдени с печати",
                            IsCorrect = false,
                            QuestionId = new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32")
                        },
                        new
                        {
                            Id = new Guid("f9300e45-a418-4642-a9bd-2692033bd6f2"),
                            AnswerText = "Иван Вазов",
                            IsCorrect = true,
                            QuestionId = new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf")
                        },
                        new
                        {
                            Id = new Guid("7006afe3-257e-4486-ac70-ca658cc6a041"),
                            AnswerText = "Климент Охридски",
                            IsCorrect = false,
                            QuestionId = new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf")
                        },
                        new
                        {
                            Id = new Guid("4c31e867-46f4-46ce-a9d8-7278ee07a8c4"),
                            AnswerText = "Йоаким Груев",
                            IsCorrect = false,
                            QuestionId = new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf")
                        },
                        new
                        {
                            Id = new Guid("b1a71edc-e238-4b40-a0f9-fc473cf81cfd"),
                            AnswerText = "Васил Левски",
                            IsCorrect = false,
                            QuestionId = new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf")
                        },
                        new
                        {
                            Id = new Guid("b9b41a63-4118-4d58-af73-e876dfc2abb8"),
                            AnswerText = "В София",
                            IsCorrect = false,
                            QuestionId = new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce")
                        },
                        new
                        {
                            Id = new Guid("e82074de-4cff-4f21-9139-82ef280f804f"),
                            AnswerText = "В Калофер",
                            IsCorrect = true,
                            QuestionId = new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce")
                        },
                        new
                        {
                            Id = new Guid("842c71c2-c554-4ed4-b329-759abee2e897"),
                            AnswerText = "В Пловдив",
                            IsCorrect = false,
                            QuestionId = new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce")
                        },
                        new
                        {
                            Id = new Guid("34f0e947-b8b9-46a6-92a5-0ff94587887d"),
                            AnswerText = "В Русе",
                            IsCorrect = false,
                            QuestionId = new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce")
                        },
                        new
                        {
                            Id = new Guid("947a7338-3502-4c20-b100-b50dea9a79c1"),
                            AnswerText = "Български революционен централен комитет",
                            IsCorrect = true,
                            QuestionId = new Guid("7ff85635-eff0-493d-89fa-af59c287b055")
                        },
                        new
                        {
                            Id = new Guid("21fc2736-5d99-429f-8467-ff4d9a09d457"),
                            AnswerText = "Българско възраждане",
                            IsCorrect = false,
                            QuestionId = new Guid("7ff85635-eff0-493d-89fa-af59c287b055")
                        },
                        new
                        {
                            Id = new Guid("0762d864-f113-4999-bb00-4c0cda0d118b"),
                            AnswerText = "Български учителски съюз",
                            IsCorrect = false,
                            QuestionId = new Guid("7ff85635-eff0-493d-89fa-af59c287b055")
                        },
                        new
                        {
                            Id = new Guid("f45a4979-eb4f-40dd-9b2f-d576214132af"),
                            AnswerText = "Българска православна църква",
                            IsCorrect = false,
                            QuestionId = new Guid("7ff85635-eff0-493d-89fa-af59c287b055")
                        },
                        new
                        {
                            Id = new Guid("0299dfe1-8380-47dc-9214-fe19431652c7"),
                            AnswerText = "‘Свобода’",
                            IsCorrect = false,
                            QuestionId = new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062")
                        },
                        new
                        {
                            Id = new Guid("adf170ce-0296-41fa-a75e-ee821996d8cf"),
                            AnswerText = "‘Пирин’",
                            IsCorrect = false,
                            QuestionId = new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062")
                        },
                        new
                        {
                            Id = new Guid("5c008254-4435-4677-85bd-7244356d84db"),
                            AnswerText = "‘Знаме’",
                            IsCorrect = true,
                            QuestionId = new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062")
                        },
                        new
                        {
                            Id = new Guid("8d31ad23-2c0a-43a6-99ba-64d0d6583bb4"),
                            AnswerText = "‘Нов Живот’",
                            IsCorrect = false,
                            QuestionId = new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062")
                        },
                        new
                        {
                            Id = new Guid("f8ae7b9f-27f1-4a25-a557-5e8bde288845"),
                            AnswerText = "Яна и Иван",
                            IsCorrect = false,
                            QuestionId = new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1")
                        },
                        new
                        {
                            Id = new Guid("fff7bcbe-5b23-4923-b261-73dfcdf0b18b"),
                            AnswerText = "Мария и Петър",
                            IsCorrect = false,
                            QuestionId = new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1")
                        },
                        new
                        {
                            Id = new Guid("ba196d92-6d4a-496d-aee3-e196d9060305"),
                            AnswerText = "Гина и Иван",
                            IsCorrect = true,
                            QuestionId = new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1")
                        },
                        new
                        {
                            Id = new Guid("b425c26e-249c-4469-b192-f2f83385111d"),
                            AnswerText = "Яна и Христо",
                            IsCorrect = false,
                            QuestionId = new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1")
                        },
                        new
                        {
                            Id = new Guid("7640beb8-bad6-4dbe-8833-0124ecb07b80"),
                            AnswerText = "Пише стихотворения",
                            IsCorrect = false,
                            QuestionId = new Guid("6481fde2-f911-426d-be91-d06d51c8bea3")
                        },
                        new
                        {
                            Id = new Guid("39d5ccd1-660a-460a-9f59-27e239d63977"),
                            AnswerText = "Пътува из страната и създава тайни революционни комитети",
                            IsCorrect = true,
                            QuestionId = new Guid("6481fde2-f911-426d-be91-d06d51c8bea3")
                        },
                        new
                        {
                            Id = new Guid("770361ca-c614-40da-b5df-78b88185f675"),
                            AnswerText = "Организира музикални събития",
                            IsCorrect = false,
                            QuestionId = new Guid("6481fde2-f911-426d-be91-d06d51c8bea3")
                        },
                        new
                        {
                            Id = new Guid("3d9f0d35-2ed2-476f-8497-9a237a8f4372"),
                            AnswerText = "Строи училища",
                            IsCorrect = false,
                            QuestionId = new Guid("6481fde2-f911-426d-be91-d06d51c8bea3")
                        },
                        new
                        {
                            Id = new Guid("4836c25e-111e-4ade-bdaa-d4ade7d58c43"),
                            AnswerText = "3 март 1840 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266")
                        },
                        new
                        {
                            Id = new Guid("180730b4-26ca-4130-b51e-6dde95147d20"),
                            AnswerText = "18 юли 1837 г.",
                            IsCorrect = true,
                            QuestionId = new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266")
                        },
                        new
                        {
                            Id = new Guid("eff4fc21-8539-4e30-aa03-a292d641c4e2"),
                            AnswerText = "1 ноември 1850 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266")
                        },
                        new
                        {
                            Id = new Guid("a3e0a3ad-b807-480a-881b-3ab517205451"),
                            AnswerText = "24 май 1835 г.",
                            IsCorrect = false,
                            QuestionId = new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266")
                        },
                        new
                        {
                            Id = new Guid("1738934d-b184-4e21-8f3b-65120d07b8af"),
                            AnswerText = "Станал е войник",
                            IsCorrect = false,
                            QuestionId = new Guid("a2e558f9-52ff-4f81-880e-df08729cb403")
                        },
                        new
                        {
                            Id = new Guid("df81bc53-94db-4bde-9caa-a0f5e85e2ad3"),
                            AnswerText = "Решил е да стане монах и приема името Игнатий",
                            IsCorrect = true,
                            QuestionId = new Guid("a2e558f9-52ff-4f81-880e-df08729cb403")
                        },
                        new
                        {
                            Id = new Guid("b8a6fdee-bdf8-4fb7-835b-faccd172a559"),
                            AnswerText = "Станал е търговец",
                            IsCorrect = false,
                            QuestionId = new Guid("a2e558f9-52ff-4f81-880e-df08729cb403")
                        },
                        new
                        {
                            Id = new Guid("235c7695-a587-40d2-9f69-db81f6622fab"),
                            AnswerText = "Отишъл е да живее в чужбина",
                            IsCorrect = false,
                            QuestionId = new Guid("a2e558f9-52ff-4f81-880e-df08729cb403")
                        },
                        new
                        {
                            Id = new Guid("aedd01c8-6ef6-449d-88ec-782f97d10a1b"),
                            AnswerText = "Радецки",
                            IsCorrect = true,
                            QuestionId = new Guid("181bcfcc-8552-4630-b5a9-7de966439d56")
                        },
                        new
                        {
                            Id = new Guid("01f036b3-bf61-48a4-ba7e-6fe48b17726b"),
                            AnswerText = "Дунав",
                            IsCorrect = false,
                            QuestionId = new Guid("181bcfcc-8552-4630-b5a9-7de966439d56")
                        },
                        new
                        {
                            Id = new Guid("28b58422-a6d9-4491-927a-14fbf91d9c2a"),
                            AnswerText = "Шипка",
                            IsCorrect = false,
                            QuestionId = new Guid("181bcfcc-8552-4630-b5a9-7de966439d56")
                        },
                        new
                        {
                            Id = new Guid("524d196c-34d4-45fb-9fc9-6c9b57f95331"),
                            AnswerText = "Вола",
                            IsCorrect = false,
                            QuestionId = new Guid("181bcfcc-8552-4630-b5a9-7de966439d56")
                        });
                });

            modelBuilder.Entity("QuizSignalR.Infrastructure.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b56d606-b794-43bc-bcf2-a396db01213d"),
                            QuestionText = "Кой български възрожденец написва 'История славянобългарска'?"
                        },
                        new
                        {
                            Id = new Guid("f8d1889c-24ad-4199-bf4c-d522d7259394"),
                            QuestionText = "В кой град е застрелян Васил Левски?"
                        },
                        new
                        {
                            Id = new Guid("a5324881-7b48-4b08-88e8-108b74040815"),
                            QuestionText = "Кога е обесен Васил Левски ?"
                        },
                        new
                        {
                            Id = new Guid("2ecabba6-33e6-4a55-862a-9949c18183e9"),
                            QuestionText = "Какво е било виждането на Васил Левски за начина, по който България трябва да бъде освободена ?"
                        },
                        new
                        {
                            Id = new Guid("2225d7e5-d606-49b0-a536-0c34515a9502"),
                            QuestionText = "Коя е основната причина за залавянето на Васил Левски ?"
                        },
                        new
                        {
                            Id = new Guid("c8174c3f-ab6a-4616-b738-877fa71a2df6"),
                            QuestionText = "Къде загива Христо Ботев ?"
                        },
                        new
                        {
                            Id = new Guid("b5865ece-b373-4e29-a90b-345fa7841a7d"),
                            QuestionText = "Къде е обесен Васил Левски ?"
                        },
                        new
                        {
                            Id = new Guid("4835fbc9-1993-4fa8-b83d-0d799b22ef32"),
                            QuestionText = "Коя от следните клаузи НЕ присъства в договора между България и Византия от 716 г., за който свидетелства Теофан ?"
                        },
                        new
                        {
                            Id = new Guid("d8fac898-fcd0-489e-bcd1-eb5130b204cf"),
                            QuestionText = "Кой български възрожденец е известен със своята поезия и романи, като 'Под игото' ?"
                        },
                        new
                        {
                            Id = new Guid("98cb2e68-9ba4-4ad3-bfe5-c1cd7d7cfbce"),
                            QuestionText = "Къде е роден Христо Ботев ?"
                        },
                        new
                        {
                            Id = new Guid("7ff85635-eff0-493d-89fa-af59c287b055"),
                            QuestionText = "Коя организация Васил Левски създава заедно с други революционери ?"
                        },
                        new
                        {
                            Id = new Guid("b1931a4c-3c43-47d1-8be8-1fe99bb42062"),
                            QuestionText = "Кой е известният вестник, основан от Христо Ботев ?"
                        },
                        new
                        {
                            Id = new Guid("3e74ff65-3933-4e4c-969d-81d21b2f6ec1"),
                            QuestionText = "Как се казват родителите на Левски?"
                        },
                        new
                        {
                            Id = new Guid("6481fde2-f911-426d-be91-d06d51c8bea3"),
                            QuestionText = "Какво прави Васил Левски, за да подготви народа за въстание ?"
                        },
                        new
                        {
                            Id = new Guid("7cbcc9c0-dc9b-4796-a901-a076957fc266"),
                            QuestionText = "Кога е роден Васил Левски ?"
                        },
                        new
                        {
                            Id = new Guid("a2e558f9-52ff-4f81-880e-df08729cb403"),
                            QuestionText = "Какво е направил Васил Левски, след като е завършил основното си образование ?"
                        },
                        new
                        {
                            Id = new Guid("181bcfcc-8552-4630-b5a9-7de966439d56"),
                            QuestionText = "Как се казва кораба, с който Ботевата чета стига до България ?"
                        });
                });

            modelBuilder.Entity("QuizSignalR.Infrastructure.Models.Answer", b =>
                {
                    b.HasOne("QuizSignalR.Infrastructure.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizSignalR.Infrastructure.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}