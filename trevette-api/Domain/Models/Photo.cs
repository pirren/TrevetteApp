using System.ComponentModel.DataAnnotations;

namespace trevette_api.Domain.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public string Url { get; set; }
        public Car Car { get; set; }
    }
}
