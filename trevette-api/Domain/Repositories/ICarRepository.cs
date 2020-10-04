using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Services.Domain.Repositories
{
    public interface ICarRepository : IRepository
    {
        Task<Car[]> ListAsync();
        Task<Car[]> GetAsync(int id);
    }
}
