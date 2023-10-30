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
            //serviceCollection.AddDbContext<RebarContext>(opt => opt.UseMongoDb("mongodb://localhost:27017/mydb"));
            
            return serviceCollection;
        }
    }
}
