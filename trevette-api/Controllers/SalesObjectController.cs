using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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
    }
}
