using AutoMapper;
using trevette_api.Domain.Models;
using trevette_api.Resources;

namespace trevette_api.Mapping
{
    public class ResourceToModel : Profile
    {
        public ResourceToModel()
        {
            CreateMap<SaveCarResource, Car>();
            CreateMap<PhotoResource, Photo>();
            CreateMap<SalesObjectResource, SalesObject>();
        }
    }
}
