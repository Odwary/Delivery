using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataAccess.Entities;

[Table("Review")]
public class ReviewEntity : BaseEntity
{
    public double Rating { get; set; }
    public string Comment { get; set; }
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    public int RestaurnatId { get; set; }
    public RestaurantEntity Restaurant { get; set; }
}