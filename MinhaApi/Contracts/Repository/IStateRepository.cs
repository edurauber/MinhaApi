using MinhaApi.Repository;
namespace MinhaApi.Contracts.Repository

{
    public interface IStateRepository
    {
        Task<IEnumerable<StateRepository>> Get();
        Task<StateRepository> GetById(int id);
    }
}
