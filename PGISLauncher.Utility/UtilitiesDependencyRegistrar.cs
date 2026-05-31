using Helpers.Utility;
using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.Interfaces;
using PGISLauncher.Utility.Security;

namespace PGISLauncher.Utility
{
    public class UtilitiesDependencyRegistrar
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICryptography, Cryptography>();
            services.AddTransient<IInstaller, Installer>();
            services.AddTransient<ILauncher, Launcher>();
            services.AddTransient<ISingleInstance, SingleInstance>();
            services.AddTransient<ISerializeData, SerializeData>();
            services.AddTransient<IStartup, Startup>();
            services.AddSingleton(typeof(IUCManager<>), typeof(UCManager<>));
            services.AddSingleton(typeof(IControlMapper<>), typeof(ControlMapper<>));
        }
    }
}
