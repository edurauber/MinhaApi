using MinhaApi.Entity;

namespace MinhaApi.DTO
{
    public class UserTokenDTO
    {
        public string Token { get; set; }
        public UserEntity User { get; set; }

    }
}
