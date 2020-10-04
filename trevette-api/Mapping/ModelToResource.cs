using AutoMapper;
using trevette_api.Domain.Models;
using trevette_api.Resources;

namespace trevette_api.Mapping
{
    public class ModelToResource : Profile
    {
        public ModelToResource()
        {
            CreateMap<Car, CarResource>();
            CreateMap<Photo, PhotoResource>();
        }
    }
}
