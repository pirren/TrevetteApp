using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services;
using trevette_api.Extensions;
using trevette_api.Resources;

namespace trevette_api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarService _service;
        private readonly IMapper _mapper;

        public CarController(ICarService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<CarResource[]> GetAllAsync()
        {
            var cars = await _service.ListAsync();
            var resources = _mapper.Map<Car[], CarResource[]>(cars);
            return resources;
        }

        [HttpGet("{id}")]
        public async Task<CarResource> GetByIdAsync(int id)
        {
            var car = await _service.GetByIdAsync(id);
            var resource = _mapper.Map<Car, CarResource>(car);
            return resource;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] SaveCarResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var car = _mapper.Map<SaveCarResource, Car>(resource);
            var result = await _service.SaveAsync(car);

            if (!result.Success)
                return BadRequest(result.Message);

            var carResource = _mapper.Map<Car, CarResource>(result.Car);
            return Ok(carResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCarResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var car = _mapper.Map<SaveCarResource, Car>(resource);
            var result = await _service.UpdateAsync(id, car);

            if (!result.Success)
                return BadRequest(result.Message);

            var carResource = _mapper.Map<Car, CarResource>(result.Car);
            return Ok(carResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var carResource = _mapper.Map<Car, CarResource>(result.Car);
            return Ok(carResource);
        }
    }
}
