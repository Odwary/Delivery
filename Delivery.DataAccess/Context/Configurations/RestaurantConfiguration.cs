using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class RestaurantConfiguration
{
    public static void ConfigureRestaurant(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RestaurantEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RestaurantEntity>().Property(x => x.Name).IsRequired();
        modelBuilder.Entity<RestaurantEntity>().Property(x => x.Rating).IsRequired();
        modelBuilder.Entity<RestaurantEntity>()
            .ToTable(tb => tb.HasCheckConstraint("CK_Restaurant_Rating", "\"Rating\" >= 0 AND \"Rating\" <= 5"));
        modelBuilder.Entity<RestaurantEntity>().Property(x => x.Address).IsRequired();

        modelBuilder.Entity<RestaurantEntity>().HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<RestaurantEntity>()
            .HasOne(r => r.FavoriteRestaurant)
            .WithMany(x => x.Restaurants)
            .HasForeignKey(r => r.FavoriteRestaurantId);
    }
}