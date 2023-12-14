using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class AddressRepository : ConnectionMovEasy, IAddressRepository
    {
        //Metodo não aplicado
        //public async Task Create(AddressDTO address)
        //{
        //    string sql = @"INSERT INTO address (Street, PostalCode, Number, Address2, District_id)
        //                        VALUE (@street, @postalCode, @number, @address2, @district_Id)";
        //    await Execute(sql, address);
        //}

        public async Task Create(AddressDTO address)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM address WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<AddressEntity>> Get()
        {
            string sql = "SELECT * FROM address";
            return await GetConnection().QueryAsync<AddressEntity>(sql);
        }

        public async Task<AddressEntity> GetById(int id)
        {
            string sql = "SELECT * FROM address WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<AddressEntity>(sql, id);
        }

        public async Task Update(AddressEntity address)
        {

            throw new NotImplementedException();
            //string sql = @"UPDATE address SET Street = @street,
            //                                  PostalCode = @postalCode,
            //                                  Number = @number,
            //                                  Address2 = @address2,
            //                                  District_Id = @district_id
            //             ";
            //await Execute(sql, address);
        }
    }
}
