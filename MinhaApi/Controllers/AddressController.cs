using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _addressRepository.Get());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _addressRepository.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post(AddressDTO address)
        {
            await _addressRepository.Create(address);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put(AddressEntity addres)
        {
            await _addressRepository.Update(addres);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _addressRepository.Delete(id);
            return Ok();
        }
    }
}
