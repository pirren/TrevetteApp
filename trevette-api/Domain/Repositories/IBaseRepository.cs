using System.Threading.Tasks;

namespace trevette_api.Domain.Repositories
{
    public interface IBaseRepository
    {
        Task Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
    }
}
