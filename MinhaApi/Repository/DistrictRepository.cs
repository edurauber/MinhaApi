using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.Infrastructure;
using MinhaApi.Entity;

namespace MinhaApi.Repository
{
    public class DistrictRepository : ConnectionMovEasy, IDistrictRepository
    {
        public async Task<IEnumerable<DistrictEntity>> Get()
        {
            string sql = "SELECT * FROM district";
            return await GetConnection().QueryAsync<DistrictEntity>(sql);
        }

        public async Task<DistrictEntity> GetById(int id)
        {
            string sql = "SELECT * FROM district WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<DistrictEntity>(sql, new { id });
        }
    }
}
