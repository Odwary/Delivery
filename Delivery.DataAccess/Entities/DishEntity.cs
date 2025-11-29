using System.ComponentModel.DataAnnotations.Schema;
using Delivery.DataAccess.Entities.Primitives;

namespace Delivery.DataAccess.Entities;

[Table("Dish")]
public class DishEntity : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Composition { get; set; }
    public virtual ICollection<CartItemsEntity> CartItems { get; set; }
    public DishCategory DishCategory { get; set; }
    public virtual ICollection<DishImageEntity> DishImages { get; set; }
    public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    public int RestaurantId { get; set; }
    public RestaurantEntity Restaurant { get; set; }
}