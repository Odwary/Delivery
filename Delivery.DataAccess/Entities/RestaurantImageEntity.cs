using System.ComponentModel.DataAnnotations.Schema;
using Delivery.DataAccess.Entities.Primitives;

namespace Delivery.DataAccess.Entities;

[Table("RestaurantImage")]
public class RestaurantImageEntity : BaseEntity
{
    public string Name { get; set; }
    public ImageFormat FileExtension { get; set; }
    
    public int RestaurantId { get; set; }
    public RestaurantEntity Restaurant { get; set; }
}