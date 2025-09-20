using System.ComponentModel.DataAnnotations;

namespace AlaElsare3.Models
{
    // المطعم
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CuisineType { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOpen { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
