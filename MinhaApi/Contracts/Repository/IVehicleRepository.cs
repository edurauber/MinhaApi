using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IVehicleRepository
    {
        Task Create(VehicleDTO vehicle);
        Task Update(VehicleEntity vehicle);
        Task Delete(int id);
        Task<VehicleEntity> GetByLicensePlate(string licensePlate);
        Task<IEnumerable<VehicleEntity>> Get();
    }
}
