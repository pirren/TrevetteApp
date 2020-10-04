using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
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

        public async Task<SalesObject> GetByIdAsync(int id)
        {
            Log.Information("Getting salesobject by id: {0}", id);
            return await _context.SalesObjects
                .Include(so => so.Car)
                .ThenInclude(c => c.Photos)
                .FirstOrDefaultAsync(so => so.SalesObjectId == id);
        }

        public async Task<SalesObject[]> ListAsync()
        {
            Log.Information("Getting all salesobjects");
            return await _context.SalesObjects
                .Include(so => so.Car)
                .ThenInclude(c => c.Photos)
                .ToArrayAsync();
        }
    }
}
