using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class CartItemConfiguration
{
    public static void ConfigureCartItem(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartItemsEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<CartItemsEntity>().ToTable(tb => tb.HasCheckConstraint(
            "CK_CartItems_Quantity", "\"Quantity\" > 0"));
        modelBuilder.Entity<CartItemsEntity>().Property(x => x.Quantity).IsRequired();

        modelBuilder.Entity<CartItemsEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<CartItemsEntity>()
            .HasOne(ci => ci.Dish)
            .WithMany(x => x.CartItems)
            .HasForeignKey(ci => ci.DishId);
    }
}