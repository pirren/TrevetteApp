using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Resources
{
    public class CarDTO
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public bool InStock { get; set; }
        public ICollection<CarBadge> CarBadges { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
