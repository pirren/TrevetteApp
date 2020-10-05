using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Linq;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Persistence.Contexts;

namespace trevette_api.Persistence.Repositories
{
    public class SalesObjectRepository : BaseRepository, ISalesObjectRepository
    {
        public SalesObjectRepository(DataContext context) : base(context)
        { }

        public async Task<SalesObject[]> ListAsync()
        {
            Log.Information("Getting all salesobjects");
            return await _context.SalesObjects.ToArrayAsync();
        }

        public async Task<SalesObject[]> ListInstockAsync()
        {
            Log.Information("Getting all salesobjects in stock");
            return await _context.SalesObjects
                .Where(so => so.InStock == true)
                .ToArrayAsync();
        }

        public async Task<SalesObject> GetByIdAsync(int id)
        {
            Log.Information("Getting salesobject by id: {0}", id);
            return await _context.SalesObjects
                .FirstOrDefaultAsync(so => so.SalesObjectId == id);
        }
    }
}
