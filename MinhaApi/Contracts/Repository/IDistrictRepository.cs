using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository

{
    public interface IDistrictRepository
    {
        Task<IEnumerable<DistrictEntity>> Get();
        Task<DistrictEntity> GetById(int id);

    }
}
