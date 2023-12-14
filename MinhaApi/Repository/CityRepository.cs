using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;
using Dapper;

namespace MinhaApi.Repository
{
    public class CityRepository : ConnectionMovEasy, ICityRepository
    {
        public async Task<IEnumerable<CityEntity>> Get()
        {
            string sql = "SELECT * FROM city";
            return await GetConnection().QueryAsync<CityEntity>(sql);
        }

        public async Task<CityEntity> GetById(int id)
        {
            string sql = "SELECT * FROM city WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<CityEntity>(sql, new { id });
        }
    }
}
