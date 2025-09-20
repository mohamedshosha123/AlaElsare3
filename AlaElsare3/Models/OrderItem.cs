using System.ComponentModel.DataAnnotations;

namespace AlaElsare3.Models
{
    // تفاصيل الطلب (عناصر الطلب)
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Price at the time of the order
        public virtual Order Order { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}


