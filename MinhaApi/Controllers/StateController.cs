using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("state")]
    public class StateController : ControllerBase
    {
        private readonly IStateRepository _stateRepository;

        public StateController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _stateRepository.Get());
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    return Ok(await _stateRepository.GetById(id));
        //}

        
    }
}
