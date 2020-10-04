using System.Threading.Tasks;

namespace trevette_api.Domain.Repositories
{
    public interface IBaseRepository
    {
        Task AddAsync<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
    }
}
