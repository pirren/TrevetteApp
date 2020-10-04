using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trevette_api.Domain.Models
{
    public class Badge
    {
        [Key]
        public int BadgeId { get; set; }
        public string Title { get; set; }
        public ICollection<CarBadge> CarBadges { get; set; }
    }
}
