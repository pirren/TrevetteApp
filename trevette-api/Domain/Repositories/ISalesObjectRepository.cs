using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Domain.Repositories
{
    public interface ISalesObjectRepository : IBaseRepository
    {
        Task<SalesObject[]> ListAsync();
        Task<SalesObject[]> ListInstockAsync();
        Task<SalesObject> GetByIdAsync(int id);
    }
}
