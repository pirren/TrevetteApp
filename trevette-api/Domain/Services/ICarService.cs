using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Domain.Services
{
    public interface ICarService
    {
        Task<Car[]> ListAsync();
        Task<SaveCarResponse> SaveAsync(Car car);
    }
}
