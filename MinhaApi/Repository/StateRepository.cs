using MinhaApi.Contracts.Repository;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class StateRepository : ConnectionMovEasy, IStateRepository
    {
        public Task<IEnumerable<StateRepository>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<StateRepository> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
