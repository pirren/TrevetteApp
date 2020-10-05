using Microsoft.EntityFrameworkCore;
using System;
using trevette_api.Domain.Models;

namespace trevette_api.Persistence.Contexts
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<SalesObject> SalesObjects { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }

        public DataContext() { }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesObject>().ToTable("SalesObject");
            modelBuilder.Entity<SalesObject>().HasKey(so => so.SalesObjectId);
            modelBuilder.Entity<SalesObject>().HasData(new
            {
                SalesObjectId = 1,
                CarId = 1,
                Title = "Tidlös maskin",
                Description = "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.",
                InStock = true,
                StartDate = DateTime.Now
            }, new
            {
                SalesObjectId = 2,
                CarId = 2,
                Title = "Odödlig",
                Description = "Denna gamla Volvo är en klassisk bakhjulsdriven personbil och går aldrig fel. Rullar fint.",
                InStock = false,
                StartDate = DateTime.Now
            });
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Car>().HasKey(c => c.CarId);
            modelBuilder.Entity<Car>().HasData(new
            {
                CarId = 1,
                Model = "Porsche 911 Carrera",
                Year = 1980,
                Mileage = 12000,
                SalesObjectId = 1
            }, new
            {
                CarId = 2,
                Model = "Volvo 240",
                Year = 1980,
                Mileage = 40000,
                SalesObjectId = 2
            }, new
            {
                CarId = 3,
                Model = "Saab 9-3",
                Year = 2012,
                Mileage = 3000
            }, new
            {
                CarId = 4,
                Model = "Ferrari 250 Testa Rossa",
                Year = 1960,
                Mileage = 15000
            });
            modelBuilder.Entity<Photo>().ToTable("Photo");
            modelBuilder.Entity<Photo>().HasKey(p => p.PhotoId);
            modelBuilder.Entity<Photo>().HasData(new
            {
                PhotoId = 1,
                FileName = "1.jpg",
                CarId = 1
            }, new
            {
                PhotoId = 2,
                FileName = "2.jpg",
                CarId = 1
            }, new
            {
                PhotoId = 3,
                FileName = "3.jpg",
                CarId = 1
            }, new
            {
                PhotoId = 4,
                FileName = "4.jpg",
                CarId = 2
            }, new
            {
                PhotoId = 5,
                FileName = "5.jpg",
                CarId = 3
            }, new
            {
                PhotoId = 6,
                FileName = "6.jpg",
                CarId = 4
            });
        }
    }
}
