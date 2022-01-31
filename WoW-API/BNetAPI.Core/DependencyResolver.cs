using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Core
{
    public static class DependencyResolver
    {
        public static void ConfigureBNetDependencies(this IServiceCollection services)
        {
            services.AddTransient<IBNetApiClient, BNetApiClient>();
            services.AddTransient<IBNetRestClient, BNetRestClient>();

            var depRegistries = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IDependencyRegistry).IsAssignableFrom(x));

            foreach (var registry in depRegistries)
            {
                var currentRegistry = registry as IDependencyRegistry;

                if (currentRegistry != null)
                {
                    currentRegistry.RegisterDependencies(services);
                }             
            }
        }
    }
}
