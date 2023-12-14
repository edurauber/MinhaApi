using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();
        //Task<CityEntity> GetById(int id);
    }
}
