using System.Collections.Generic;

namespace trevette_api.Resources
{
    public class SaveCarResource
    {
        public int CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
