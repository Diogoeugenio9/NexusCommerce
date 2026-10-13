using Microsoft.EntityFrameworkCore;
using NexusCommerce.Orders.API.Entities;

namespace NexusCommerce.Orders.API.Data;

public class OrdersDbContext : DbContext
{
    public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options) { }

    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(e =>
        {
            e.Property(o => o.TotalAmount).HasPrecision(18, 2);
            e.Property(o => o.Status).HasConversion<string>();
            e.HasMany(o => o.Items)
             .WithOne()
             .HasForeignKey(i => i.OrderId);
        });

        modelBuilder.Entity<OrderItem>()
            .Property(i => i.UnitPrice).HasPrecision(18, 2);
    }
}