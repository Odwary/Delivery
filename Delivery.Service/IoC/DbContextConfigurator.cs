using Microsoft.EntityFrameworkCore;
using Delivery.Service.Settings;
using Delivery.DataAccess.Context;


namespace Delivery.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, DeliverySettings settings)
    {
        services.AddDbContextFactory<DeliveryDbContext>(options =>
        {
            options.UseNpgsql(settings.DeliveryDbConnectionString);
        }, ServiceLifetime.Scoped);

    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DeliveryDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}