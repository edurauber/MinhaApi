using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserDTO user);
        Task Update(UserEntity user);
        Task Delete(int id);
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> Get();

        Task<UserTokenDTO> LogIn(UserLoginDTO user);
    }
}
