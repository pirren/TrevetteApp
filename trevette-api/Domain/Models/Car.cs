using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trevette_api.Domain.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public SalesObject SalesObject { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
