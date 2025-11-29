using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("OrderItem")]
public class OrderItemEntity : BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    
    public int OrderId { get; set; }
    public OrderEntity Order { get; set; }
    
    public int DishId { get; set; }
    public DishEntity Dish { get; set; }
}