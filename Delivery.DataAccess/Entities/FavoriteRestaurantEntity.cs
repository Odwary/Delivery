using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("FavoriteRestaurant")]
public class FavoriteRestaurantEntity : BaseEntity
{
    public DateTime AddedAt { get; set; }
    public virtual ICollection<RestaurantEntity> Restaurants { get; set; }
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}