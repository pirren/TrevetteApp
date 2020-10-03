using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trevette_api.Models;
using Serilog;

namespace trevette_api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        public CarController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            Log.Information("Test");
            return Ok("Hej");
        }
    }
}
