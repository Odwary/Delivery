using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class RestaurantImageConfiguration
{
    public static void ConfigureRestaurantImage(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RestaurantImageEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RestaurantImageEntity>()
            .HasIndex(ri => ri.ExternalId)
            .IsUnique();

        modelBuilder.Entity<RestaurantImageEntity>().Property(ri => ri.FileExtension)
            .HasConversion<string>()
            .IsRequired();

        modelBuilder.Entity<RestaurantImageEntity>()
            .HasOne(ri => ri.Restaurant)
            .WithMany(x => x.RestaurantImages)
            .HasForeignKey(ri => ri.RestaurantId);
    }
}