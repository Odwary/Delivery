using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("CartItem")]
public class CartItemsEntity : BaseEntity
{
    public int Quantity { get; set; }
    public virtual ICollection<CartEntity> Carts { get; set; }
    public int DishId { get; set; }
    public DishEntity Dish { get; set; }
}