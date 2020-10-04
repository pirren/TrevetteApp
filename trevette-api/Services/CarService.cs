using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Domain.Services;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CarService(ICarRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Car[]> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<SaveCarResponse> SaveAsync(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}
