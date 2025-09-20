namespace AlaElsare3.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int EntityId { get; set; } // Can be a RestaurantId or DriverId
        public string EntityType { get; set; } // "Restaurant" or "Driver"
        public int Rating { get; set; } // 1-5 stars
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public virtual User User { get; set; }
    }
}
