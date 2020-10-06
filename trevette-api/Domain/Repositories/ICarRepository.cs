using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Domain.Repositories
{
    public interface ICarRepository : IBaseRepository
    {
        Task<Car[]> ListAsync();
        Task<Car[]> ListForsaleAsync();
        Task<Car> FindByIdAsync(int id);
    }
}
