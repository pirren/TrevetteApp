using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trevette_api.Models;
using Serilog;

namespace trevette_api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            Log.Information("Test");
            return Ok("Hej");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
