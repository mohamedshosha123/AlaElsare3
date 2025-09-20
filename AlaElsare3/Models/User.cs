using System.ComponentModel.DataAnnotations;

namespace AlaElsare3.Models
{
    // المستخدم (عميل / مطعم / مدير)
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Hashed password for security
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
