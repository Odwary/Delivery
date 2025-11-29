using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("Cart")]
public class CartEntity : BaseEntity
{
    public decimal TotalSum { get; set; }
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    public virtual ICollection<CartItemsEntity> CartItems { get; set; }
}