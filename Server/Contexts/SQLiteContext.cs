namespace YugiTrivia.Server.Contexts;
using Microsoft.EntityFrameworkCore;
using YugiTrivia.Shared;

public class SQLiteContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public SQLiteContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(_configuration.GetConnectionString("CardsDB"));
    }

    DbSet<TriviaCard> triviaCards { get; set; }

    DbSet<CardSet> cardSets { get; set; }
}
