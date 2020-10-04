using System.ComponentModel.DataAnnotations;

namespace trevette_api.Resources
{
    public class SaveCarResource
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int Mileage { get; set; }
    }
}
