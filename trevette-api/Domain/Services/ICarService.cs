using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Domain.Services
{
    public interface ICarService
    {
        Task<Car[]> ListAsync();
        Task<Car> GetByIdAsync(int id);
        Task<CarResponse> SaveAsync(Car car);
        Task<CarResponse> UpdateAsync(int id, Car resource);
        Task<CarResponse> DeleteAsync(int id);
    }
}
