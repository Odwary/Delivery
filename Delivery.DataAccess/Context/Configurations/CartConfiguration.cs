using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class CartConfiguration
{
    public static void ConfigureCart(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<CartEntity>().Property(x => x.TotalSum).IsRequired();
        modelBuilder.Entity<CartEntity>().ToTable(tb => tb.HasCheckConstraint(
            "CK_Cart_TotalSum", "\"TotalSum\" >= 0"));
        modelBuilder.Entity<CartEntity>().Property(x => x.CreatedAt).IsRequired();
        modelBuilder.Entity<CartEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<CartEntity>()
            .HasOne(c => c.User)
            .WithOne(x => x.Cart)
            .HasForeignKey<CartEntity>(c => c.UserId);
    }
}