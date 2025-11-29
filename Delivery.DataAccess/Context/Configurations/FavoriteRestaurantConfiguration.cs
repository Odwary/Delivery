using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class FavoriteRestaurantConfiguration
{
    public static void ConfigureFavoriteRestaurant(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FavoriteRestaurantEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<FavoriteRestaurantEntity>().Property(x => x.AddedAt).IsRequired();

        modelBuilder.Entity<FavoriteRestaurantEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<FavoriteRestaurantEntity>()
            .HasOne(fr => fr.User)
            .WithMany(x => x.FavoriteRestaurants)
            .HasForeignKey(fr => fr.UserId);
    }
}