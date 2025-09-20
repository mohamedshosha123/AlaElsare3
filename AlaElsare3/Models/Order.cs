using System.ComponentModel.DataAnnotations;

namespace AlaElsare3.Models
{
    // الطلب
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; } // e.g., Placed, Preparing, OnTheWay, Delivered
        public decimal TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Placed,
        Accepted,
        Preparing,
        OnTheWay,
        Delivered,
        Cancelled
    }

}
