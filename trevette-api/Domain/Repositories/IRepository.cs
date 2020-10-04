using System.Threading.Tasks;

namespace trevette_api.Services.Domain.Repositories
{
    public interface IRepository
    {
        Task Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
    }
}
