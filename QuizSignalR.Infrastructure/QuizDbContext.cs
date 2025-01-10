using Microsoft.EntityFrameworkCore;
using QuizSignalR.Infrastructure.Models;
using System.Reflection;

namespace QuizSignalR.Infrastructure;

public class QuizDbContext : DbContext
{
    public QuizDbContext()
    {
        
    }

    public QuizDbContext(DbContextOptions options)
        : base(options)
    {

    }

    //public DbSet<Player> Players { get; set; }
    //public DbSet<GameState> GameStates { get; set; }
    public DbSet<Question> Questions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var configurationAssembly = Assembly.GetAssembly(typeof(QuizDbContext)) ??
                                    Assembly.GetExecutingAssembly();

        builder.ApplyConfigurationsFromAssembly(configurationAssembly);

        base.OnModelCreating(builder);
    }
}