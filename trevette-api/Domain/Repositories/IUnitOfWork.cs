using System.Threading.Tasks;

namespace trevette_api.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
