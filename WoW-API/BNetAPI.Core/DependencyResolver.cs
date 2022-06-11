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

            var depRegistries = AppDomain.CurrentDomain.GetAssemblies();

            var types = depRegistries.SelectMany(x => x.GetTypes());
            var depRegistries2 = types.Where(x => typeof(IDependencyRegistry).IsAssignableFrom(x)).Skip(1);

            foreach (var registry in depRegistries2)
            {
                var currentRegistry = Activator.CreateInstance(registry) as IDependencyRegistry;
                currentRegistry?.RegisterDependencies(services);
            }
        }
    }
}
