using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class DishConfiguration
{
    public static void ConfigureDish(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DishEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<DishEntity>()
            .ToTable(tb => tb.HasCheckConstraint("CK_Dish_Price", "\"Price\" > 0"));
        modelBuilder.Entity<DishEntity>().Property(x => x.Price).IsRequired();
        modelBuilder.Entity<DishEntity>().Property(x => x.Composition).IsRequired();
        modelBuilder.Entity<DishEntity>().Property(x => x.Name).IsRequired();
        modelBuilder.Entity<DishEntity>().Property(x => x.DishCategory)
            .HasConversion<string>()
            .IsRequired();

        modelBuilder.Entity<DishEntity>()
            .HasIndex(x => x.ExternalId)
            .IsUnique();

        modelBuilder.Entity<DishEntity>()
            .HasOne(d => d.Restaurant)
            .WithMany(x => x.Dishes)
            .HasForeignKey(d => d.RestaurantId);
    }
}