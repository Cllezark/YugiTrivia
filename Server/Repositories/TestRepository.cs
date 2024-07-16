using YugiTrivia.Server.Contexts;
using Microsoft.EntityFrameworkCore.Sqlite;
using YugiTrivia.Shared;
using Dapper;
using YugiTrivia.Server.Interfaces;

namespace YugiTrivia.Server.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly DapperContext _context;

        public TestRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<TriviaCard> GetRandomCard()
        {
            string query = "SELECT Id, Name, Type, TcgDate, OcgDate, Artwork FROM card_reference ORDER BY Random() LIMIT 1";

            using (var connection = _context.CreateConnection())
            {
                var randomCard = await connection.QueryFirstAsync<TriviaCard>(query);
                return randomCard;
            }
        }


    }
}
