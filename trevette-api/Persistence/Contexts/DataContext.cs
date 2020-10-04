using Microsoft.EntityFrameworkCore;
using trevette_api.Domain.Models;

namespace trevette_api.Persistence.Contexts
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public DataContext() { }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Car>().HasKey(p => p.CarId);
            modelBuilder.Entity<Car>().HasData(new
            {
                CarId = 1,
                Model = "Porsche 911 Carrera",
                Year = 1980,
                Mileage = 15000,
                Title = "Tidlös maskin",
                Description = "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.",
                InStock = true
            });

            modelBuilder.Entity<Badge>().ToTable("Badge");
            modelBuilder.Entity<Badge>().HasKey(p => p.BadgeId);
            modelBuilder.Entity<Badge>().HasData(new
            {
                BadgeId = 1,
                Title = "V8 Motor"
            }, new
            {
                BadgeId = 2,
                Title = "Läderinredning"
            }, new
            {
                BadgeId = 3,
                Title = "Specialobjekt"
            });

            modelBuilder.Entity<CarBadge>().ToTable("CarBadge");
            modelBuilder.Entity<CarBadge>().HasKey(cb => new { cb.CarId, cb.BadgeId});
            modelBuilder.Entity<CarBadge>().HasOne(cb => cb.Car)
                .WithMany(c => c.CarBadges)
                .HasForeignKey(cb => cb.CarId);
            modelBuilder.Entity<CarBadge>().HasOne(cb => cb.Badge)
                .WithMany(b => b.CarBadges)
                .HasForeignKey(cb => cb.BadgeId);
            modelBuilder.Entity<CarBadge>().HasData(new
            {
                CarId = 1,
                BadgeId = 1
            }, new
            {
                CarId = 1,
                BadgeId = 2
            }, new
            {
                CarId = 1,
                BadgeId = 3
            });
        }
    }
}
