using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Linq;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Persistence.Contexts;

namespace trevette_api.Persistence.Repositories
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(DataContext context) : base(context)
        { }

        public async Task<Car[]> ListAsync()
        {
            Log.Information("Getting all cars");
            return await _context.Cars.Include(c => c.Photos)
                .Include(c => c.SalesObject)
                .ToArrayAsync();
        }

        public async Task<Car[]> ListForsaleAsync()
        {
            Log.Information("Getting all cars for sale");
            return await _context.Cars.Include(c => c.Photos)
                .Include(c => c.SalesObject)
                .Where(c => c.SalesObject.InStock == true)
                .ToArrayAsync();
        }

        public async Task<Car> FindByIdAsync(int id)
        {
            Log.Information("Getting car by id: {0}", id);
            return await _context.Cars.Include(c => c.Photos)
                .Include(c => c.SalesObject)
                .FirstOrDefaultAsync(c => c.CarId == id);
        }
    }
}
