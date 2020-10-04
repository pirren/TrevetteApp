using Serilog;
using System.Threading.Tasks;
using trevette_api.Domain.Repositories;
using trevette_api.Persistence.Contexts;

namespace trevette_api.Persistence.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            Log.Information("Adding entity of type {0}", entity.GetType());
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            Log.Information("Updating entity of type {0}", entity.GetType());
            _context.Set<T>().Update(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            Log.Information("Removing entity of type {0}", entity.GetType());
            _context.Set<T>().Remove(entity);
        }
    }
}
