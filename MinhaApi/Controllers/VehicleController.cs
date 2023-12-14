using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;
using MinhaApi.Repository;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _vehicleRepository.Get());
        }

        [HttpGet("{licensePlate}")]
        public async Task<IActionResult> GetByLicensePlate(string licensePlate) 
        {
            return Ok(await _vehicleRepository.GetByLicensePlate(licensePlate));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _vehicleRepository.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleDTO vehicle)
        {
            await _vehicleRepository.Create(vehicle);
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Update(VehicleEntity vehicle)
        {
            await _vehicleRepository.Update(vehicle);
            return Ok();
        }
        
    }
}
