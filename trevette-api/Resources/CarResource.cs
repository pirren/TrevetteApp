using System.Collections.Generic;

namespace trevette_api.Resources
{
    public class CarResource
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public SalesObjectResource SalesObject { get; set; }
        public ICollection<PhotoResource> Photos { get; set; }
    }
}
