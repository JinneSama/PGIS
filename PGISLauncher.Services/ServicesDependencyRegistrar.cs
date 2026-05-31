using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.Interfaces;
using PGISLauncher.Repository;

namespace PGISLauncher.Services
{
    public class ServicesDependencyRegistrar
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<,>), typeof(BaseRepository<,>));
        }
    }
}
