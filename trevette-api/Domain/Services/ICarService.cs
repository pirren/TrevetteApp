using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Domain.Services
{
    public interface ICarService
    {
        Task<Car[]> ListAsync();
    }
}
