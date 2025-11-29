using System.ComponentModel.DataAnnotations.Schema;
using Delivery.DataAccess.Entities.Primitives;

namespace Delivery.DataAccess.Entities;

[Table("Users")]
public class UserEntity : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public string Email { get; set; }
    public UserRole UserRole { get; set; }
    public virtual ICollection<OrderEntity> Orders { get; set; }
    public virtual ICollection<ReviewEntity> Reviews { get; set; }
    public virtual ICollection<FavoriteRestaurantEntity> FavoriteRestaurants { get; set; }
    
    public int CartId { get; set; }
    public CartEntity Cart { get; set; }
}