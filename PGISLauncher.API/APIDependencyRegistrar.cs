using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.API.Common;
using PGISLauncher.API.Manager;
using PGISLauncher.API.Service;
using PGISLauncher.Core.Common;
using PGISLauncher.Interfaces;

namespace PGISLauncher.API
{
    public class APIDependencyRegistrar
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ITokenCache, TokenCache>();
            services.AddSingleton(typeof(AuthBackend));
            services.AddSingleton(typeof(FileService));
            services.AddSingleton(typeof(OFMISService));
            services.AddSingleton(typeof(OFMISManager));
            services.AddSingleton(typeof(UserAppManager));
            services.AddSingleton(typeof(UserStore));
            services.AddSingleton(typeof(EnumHelper));
        }
    }
}
