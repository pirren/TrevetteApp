using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trevette_api.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Title { get; set;  }
        public string Description { get; set; }
        public int? Price { get; set; }
        public bool InStock { get; set; }
        public ICollection<CarBadge> CarBadges { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
