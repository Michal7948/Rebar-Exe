using Repositories.Models;


namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IShakeRepository, ShakeRepository>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddDbContext<RebarContext>(opt => opt.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\מסלול\פרוייקט WEB\Web project\DB\WebProject.mdf;Integrated Security=True;Connect Timeout=30"));
            return serviceCollection;
        }
    }
}
