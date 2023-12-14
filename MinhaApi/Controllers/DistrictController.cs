using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("district")]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictRepository _districtRepository;

        public DistrictController(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _districtRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _districtRepository.GetById(id));
        }
    }
}
