using BNetAPI.Core.Helpers;
using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Core
{
    public static class DependencyResolver
    {
        public static void ConfigureBNetDependencies(this IServiceCollection services)
        {
            services.AddTransient<IBNetRestClient, BNetRestClient>();
            services.AddTransient<IUrlHelper, UrlHelper>();

            var depRegistries = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IDependencyRegistry).IsAssignableFrom(x)).Skip(1);

            foreach (var registry in depRegistries)
            {
                var currentRegistry = Activator.CreateInstance(registry) as IDependencyRegistry;
                currentRegistry?.RegisterDependencies(services);
            }
        }
    }
}
