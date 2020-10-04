namespace trevette_api.Domain.Models
{
    public class CarBadge
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int BadgeId { get; set; }
        public Badge Badge { get; set; }
    }
}
