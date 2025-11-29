using System.ComponentModel.DataAnnotations.Schema;
using Delivery.DataAccess.Entities.Primitives;

namespace Delivery.DataAccess.Entities;

[Table("Order")]
public class OrderEntity : BaseEntity
{
    public string DeliveryAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public PaymentMethods PaymentMethod { get; set; }
    public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    public int RestaurantId { get; set; }
    public RestaurantEntity Restaurant { get; set; }
}