using Microsoft.EntityFrameworkCore;

namespace ShoppingApi.Models
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
