using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Domain.Repositories
{
    public interface ICarRepository : IBaseRepository
    {
        Task<Car[]> ListAsync();
        Task AddAsync(Car car);
        Task<Car> FindByIdAsync(int id);
        void Update(Car car);
        void Remove(Car car);
    }
}
