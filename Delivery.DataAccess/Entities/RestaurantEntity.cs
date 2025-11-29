using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("Restaurant")]
public class RestaurantEntity : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Rating { get; set; }
    public virtual ICollection<ReviewEntity> Reviews { get; set; }
    public virtual ICollection<DishEntity> Dishes { get; set; }
    public virtual ICollection<OrderEntity> Orders { get; set; }
    public virtual ICollection<RestaurantImageEntity> RestaurantImages { get; set; }
    public int FavoriteRestaurantId { get; set; }
    public FavoriteRestaurantEntity FavoriteRestaurant;
}