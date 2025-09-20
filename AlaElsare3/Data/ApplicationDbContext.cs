using AlaElsare3.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AlaElsare3.Data
{
    public class ApplicationDbContext :DbContext
    {
        // DbContext
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        // Order model
        public class Order
        {
            public int OrderId { get; set; }
            public virtual ICollection<OrderItem> OrderItems { get; set; }
        }

        // OrderItem model
        public class OrderItem
        {
            public int OrderItemId { get; set; }
            public int OrderId { get; set; }
            public virtual Order Order { get; set; }

            public int MenuItemId { get; set; }
            public virtual MenuItem MenuItem { get; set; }
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=True;Connect Timeout=60;Initial Catalog= talabe12;Encrypt=True;" +
                "Trust Server Certificate=True;");
        }



    }

}
