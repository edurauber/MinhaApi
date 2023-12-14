using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IAddressRepository
    {
        Task Create(AddressDTO address);
        Task<AddressEntity> GetById(int id);
        Task<IEnumerable<AddressEntity>> Get();
        Task Update(AddressEntity address);
        Task Delete(int id);
    }
}
