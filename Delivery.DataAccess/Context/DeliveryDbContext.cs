using Delivery.DataAccess.Context.Configurations;
using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context;

public class DeliveryDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CartEntity> Cart { get; set; }
    public DbSet<CartItemsEntity> CartItems { get; set; }
    public DbSet<DishEntity> Dish { get; set; }
    public DbSet<DishImageEntity> DishImage { get; set; }
    public DbSet<FavoriteRestaurantEntity> FavoriteRestaurant { get; set; }
    public DbSet<OrderEntity> Order { get; set; }
    public DbSet<OrderItemEntity> OrderItem { get; set; }
    public DbSet<RestaurantEntity> Restaurant { get; set; }
    public DbSet<RestaurantImageEntity> RestaurantImage { get; set; }
    public DbSet<ReviewEntity> Review { get; set; }

    public DeliveryDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureCart();
        modelBuilder.ConfigureCartItem();
        modelBuilder.ConfigureDish();
        modelBuilder.ConfigureDishImage();
        modelBuilder.ConfigureFavoriteRestaurant();
        modelBuilder.ConfigureOrder();
        modelBuilder.ConfigureOrderItem();
        modelBuilder.ConfigureRestaurant();
        modelBuilder.ConfigureRestaurantImage();
        modelBuilder.ConfigureReview();
        modelBuilder.ConfigureUser();
    }
}