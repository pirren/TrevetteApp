using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services;
using trevette_api.Resources;

namespace trevette_api.Controllers
{
    [Route("api/v1.0/[controller]/")]
    [ApiController]
    public class SalesObjectController : Controller
    {
        private readonly ISalesObjectService _service;
        private readonly IMapper _mapper;

        public SalesObjectController(ISalesObjectService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<SalesObjectResource[]> GetAllAsync()
        {
            var salesobjects = await _service.ListAsync();
            var resources = _mapper.Map<SalesObject[], SalesObjectResource[]>(salesobjects);
            return resources;
        }

        [HttpGet]
        [Route("Instock")]
        public async Task<SalesObjectResource[]> GetAllInstockAsync()
        {
            var salesobjects = await _service.ListInstockAsync();
            var resources = _mapper.Map<SalesObject[], SalesObjectResource[]>(salesobjects);
            return resources;
        }
    }
}
