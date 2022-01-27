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
        }
    }
}
