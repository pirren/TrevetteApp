using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trevette_api.Models
{
    public class CarBadge
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int BadgeId { get; set; }
        public Badge Badge { get; set; }
    }
}
