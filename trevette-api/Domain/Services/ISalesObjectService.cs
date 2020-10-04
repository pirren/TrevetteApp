using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Domain.Services
{
    public interface ISalesObjectService
    {
        Task<SalesObject[]> ListAsync();
        Task<SalesObject> GetByIdAsync(int id);
        Task<SalesObjectResponse> SaveAsync();
        Task<SalesObjectResponse> DeleteAsync();
        Task<SalesObjectResponse> UpdateAsync();
    }
}
