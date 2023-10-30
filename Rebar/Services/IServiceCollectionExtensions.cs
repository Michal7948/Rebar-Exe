using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace Services
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IShakeService, ShakeService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            serviceCollection.AddRepositories();
            return serviceCollection;
        }
    }
}
