namespace Delivery.DataAccess.Entities.Primitives;

public enum OrderStatus
{
    New = 0,
    InPreparation = 1,
    OnTheWay = 2,
    Delivered = 3,
    Canceled = 4
}