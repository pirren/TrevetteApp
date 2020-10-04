using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trevette_api.Domain.Models
{
    public class SalesObject
    {
        [Key]
        public int SalesObjectId { get; set; }
        public Car Car { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public bool InStock { get; set; }
        public DateTime StartDate { get; set; }
    }
}
