namespace AlaElsare3.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int DriverId { get; set; }
        public DateTime? PickedUpTime { get; set; }
        public DateTime? DeliveredTime { get; set; }
        public DeliveryStatus Status { get; set; } // e.g., AwaitingDriver, PickedUp, Delivered
        public virtual Order Order { get; set; }
        public virtual DeliveryDriver Driver { get; set; }
    }

    public enum DeliveryStatus
    {
        AwaitingDriver,
        PickedUp,
        Delivered
    }
}
