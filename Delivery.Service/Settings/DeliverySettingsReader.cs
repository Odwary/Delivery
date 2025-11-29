namespace Delivery.Service.Settings
{
    public static class DeliverySettingsReader
    {
        public static DeliverySettings Read(IConfiguration configuration)
        {
            return new DeliverySettings()
            {
                DeliveryDbConnectionString =
                    configuration.GetConnectionString("DeliveryDbContext")
            };
        }
    }
}