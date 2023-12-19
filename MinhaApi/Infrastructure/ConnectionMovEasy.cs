using MySql.Data.MySqlClient;
using Dapper;

namespace MinhaApi.Infrastructure
{
    public class ConnectionMovEasy
    {
        protected string connectionString = "Server=localhost;Database=MovEasy;User=root;Password=root;";

        protected MySqlConnection GetConnection() 
        {
            return new MySqlConnection(connectionString);
        }
        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection conn = GetConnection())
            {
                return await conn.ExecuteAsync(sql, obj);
            }
        }
    }
}
