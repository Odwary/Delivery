using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class OrderConfiguration
{
    public static void ConfigureOrder(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<OrderEntity>().Property(x => x.TotalAmount).IsRequired();
        modelBuilder.Entity<OrderEntity>()
            .ToTable(tb => tb.HasCheckConstraint("CK_Order_TotalAmount", "\"TotalAmount\" > 0"));
        modelBuilder.Entity<OrderEntity>().Property(x => x.DeliveryAddress).IsRequired();
        modelBuilder.Entity<OrderEntity>().Property(x => x.OrderDate).IsRequired();
        
        modelBuilder.Entity<OrderEntity>().Property(x => x.OrderStatus)
            .HasConversion<string>()
            .IsRequired();
        
        modelBuilder.Entity<OrderEntity>().Property(x => x.PaymentMethod)
            .HasConversion<string>()
            .IsRequired();

        modelBuilder.Entity<OrderEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<OrderEntity>()
            .HasOne(o => o.User)
            .WithMany(x => x.Orders)
            .HasForeignKey(o => o.UserId);

        modelBuilder.Entity<OrderEntity>()
            .HasOne(o => o.Restaurant)
            .WithMany(x => x.Orders)
            .HasForeignKey(o => o.RestaurantId);
    }
}