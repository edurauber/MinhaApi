using MinhaApi.Entity;
namespace MinhaApi.Contracts.Repository

{
    public interface IStateRepository
    {
        Task<IEnumerable<StateEntity>> Get();
        Task<StateEntity> GetById(int id);
    }
}
