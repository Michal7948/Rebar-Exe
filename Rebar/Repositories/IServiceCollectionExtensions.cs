using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using MongoDB.Driver;

namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IShakeRepository, ShakeRepository>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddScoped<IDailyReportRepository, DailyReportRepository>();
            return serviceCollection;
        }
    }
}
