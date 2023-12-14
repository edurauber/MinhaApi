using Dapper;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class StateRepository : ConnectionMovEasy, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM state";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }

        //public async Task<StateEntity> GetById(int id)
        //{
        //    string sql = "SELECT * FROM state WHERE Id = @id";
        //    return await GetConnection().QueryFirstAsync<StateEntity>(sql, new { id });
        //}
    }
}
