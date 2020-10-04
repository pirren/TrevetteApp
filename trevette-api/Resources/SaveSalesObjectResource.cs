using System.ComponentModel.DataAnnotations;
using trevette_api.Domain.Models;

namespace trevette_api.Resources
{
    public class SaveSalesObjectResource
    {
        [Required]
        public Car Car { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int? Price { get; set; }
        [Required]
        public bool InStock { get; set; }
    }
}
