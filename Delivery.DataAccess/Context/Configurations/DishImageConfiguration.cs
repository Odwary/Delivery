using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class DishImageConfiguration
{
    public static void ConfigureDishImage(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DishImageEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<DishImageEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<DishImageEntity>().Property(x => x.FileExtension)
            .HasConversion<string>()
            .IsRequired();
    }
}