using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class OrderItemConfiguration
{
    public static void ConfigureOrderItem(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItemEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<OrderItemEntity>().Property(x => x.Price).IsRequired();
        modelBuilder.Entity<OrderItemEntity>()
            .ToTable(tb => tb.HasCheckConstraint("CK_OrderItem_Price", "\"Price\" > 0"));
        modelBuilder.Entity<OrderItemEntity>().Property(x => x.Quantity).IsRequired();
        modelBuilder.Entity<OrderItemEntity>()
            .ToTable(tb => tb.HasCheckConstraint("CK_OrderItem_Quantity", "\"Quantity\" > 0"));
        modelBuilder.Entity<OrderItemEntity>()
            .HasIndex(oi => oi.ExternalId)
            .IsUnique();

        modelBuilder.Entity<OrderItemEntity>()
            .HasOne(oi => oi.Dish)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(oi => oi.DishId);

        modelBuilder.Entity<OrderItemEntity>()
            .HasOne(oi => oi.Order)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(oi => oi.OrderId);
    }
}