using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Persistence.Contexts;

namespace trevette_api.Persistence.Repositories
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(DataContext context) : base(context)
        {

        }

        public async Task<Car[]> ListAsync()
        {
            Log.Information("Getting all cars");
            return await _context.Cars.ToArrayAsync();
        }

        public async Task<Car> FindByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task AddAsync(Car car)
        {
            Log.Information("Adding car");
            await _context.Cars.AddAsync(car);
        }

        public void Update(Car car)
        {
            _context.Cars.Update(car);
        }

        public void Remove(Car car)
        {
            _context.Cars.Remove(car);
        }
    }
}
