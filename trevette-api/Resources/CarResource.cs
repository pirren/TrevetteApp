using System.Collections.Generic;
using trevette_api.Domain.Models;

namespace trevette_api.Resources
{
    public class CarResource
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
