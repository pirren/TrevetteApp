using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services;

namespace trevette_api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarService _service;
        public CarController(ICarService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<Car[]> GetAllAsync()
        {
            var cars = await _service.ListAsync();
            return cars;
        }
    }
}
