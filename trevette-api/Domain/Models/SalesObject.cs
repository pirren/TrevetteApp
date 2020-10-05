using System;
using System.ComponentModel.DataAnnotations;

namespace trevette_api.Domain.Models
{
    public class SalesObject
    {
        [Key]
        public int SalesObjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public bool InStock { get; set; }
        public DateTime StartDate { get; set; }
    }
}
