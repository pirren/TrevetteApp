using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services;
using trevette_api.Services.Domain.Repositories;

namespace trevette_api.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<Car[]> ListAsync()
        {
            return await _repository.ListAsync();
        }

    }
}
