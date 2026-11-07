using Microsoft.EntityFrameworkCore;
using NexusCommerce.Inventory.API.Entities;

namespace NexusCommerce.Inventory.API.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(i => i.Price).HasPrecision(18, 2);
        }
    }
}
