using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.Base;
using System;
using System.Linq;

namespace PGISLauncher.Dependency
{
    public static class ControlDependencyRegistrar
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterForms(services);
        }

        public static void RegisterForms(IServiceCollection services)
        {
            var formTypes = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(a => a.GetTypes())
                    .Where(t => (t.IsSubclassOf(typeof(BaseForm))) && !t.IsAbstract && !t.IsGenericType);

            foreach (var formType in formTypes)
            {
                services.AddTransient(formType);
            }
        }
    }
}
