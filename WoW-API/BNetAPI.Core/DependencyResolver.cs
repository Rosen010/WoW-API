using BNetAPI.Core.Helpers;
using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Core
{
    public static class DependencyResolver
    {
        public static void AddBNetApi(this IServiceCollection services)
        {
            services.AddTransient<IBNetRestClient, BNetRestClient>();
            services.AddTransient<IUrlHelper, UrlHelper>();
        }
    }
}
