namespace YugiTrivia.Server.Contexts;
using Microsoft.EntityFrameworkCore;
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

}
