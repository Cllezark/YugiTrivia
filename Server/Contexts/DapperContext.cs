using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;
using YugiTrivia.Shared;

namespace YugiTrivia.Server.Contexts
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;

        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("CardsDB");
        }

        public IDbConnection CreateConnection() => new SqliteConnection(_connectionString);

    }
}
