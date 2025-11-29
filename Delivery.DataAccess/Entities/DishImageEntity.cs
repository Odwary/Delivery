using System.ComponentModel.DataAnnotations.Schema;
using Delivery.DataAccess.Entities.Primitives;

namespace Delivery.DataAccess.Entities;

[Table("DishImage")]
public class DishImageEntity : BaseEntity
{
    public string Name { get; set; }
    public ImageFormat FileExtension { get; set; }
    public byte[] Content { get; set; }
    public virtual ICollection<DishEntity> Dishes { get; set; }
}