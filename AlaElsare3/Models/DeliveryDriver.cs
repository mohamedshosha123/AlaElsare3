namespace AlaElsare3.Models
{
    public class DeliveryDriver
    {
        // Add this property to define the primary key
        public int Id { get; set; }
        // OR
        // public int DeliveryDriverId { get; set; } 

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsAvailable { get; set; }
    }

}
