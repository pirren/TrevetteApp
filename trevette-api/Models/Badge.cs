using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trevette_api.Models
{
    public class Badge
    {
        [Key]
        public int BadgeId { get; set; }
        public string Title { get; set; }
        public ICollection<CarBadge> CarBadges { get; set; }
    }
}
