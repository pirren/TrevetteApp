using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Persistence.Contexts;
using trevette_api.Services.Domain.Repositories;

namespace trevette_api.Persistence.Repositories
{
    public class CarRepository : Repository, ICarRepository
    {
        public CarRepository(DataContext context) : base(context)
        {

        }

        public async Task<Car[]> ListAsync()
        {
            Log.Information("Getting all cars");
            return await _context.Cars.ToArrayAsync();
        }

        public Task<Car[]> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
