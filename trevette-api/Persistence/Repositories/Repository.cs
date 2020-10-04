using Serilog;
using System.Threading.Tasks;
using trevette_api.Persistence.Contexts;
using trevette_api.Services.Domain.Repositories;

namespace trevette_api.Persistence.Repositories
{
    public class Repository : IRepository
    {
        protected readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public async Task Add<T>(T entity) where T : class
        {
            Log.Information("Adding entity of type {0}", entity.GetType());
            await _context.AddAsync(entity);

        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
