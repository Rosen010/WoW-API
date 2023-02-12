using BNetAPI.Core.Components.Characters.Models.Interfaces;
using BNetAPI.Core.Components.Characters;
using BNetAPI.Core.Components.Guilds;
using BNetAPI.Core.Helpers;
using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using BNetAPI.Accounts.Interfaces;
using BNetAPI.Accounts;

namespace BNetAPI.Core
{
    public static class DependencyResolver
    {
        public static void AddBNetApi(this IServiceCollection services)
        {
            services.AddTransient<IBNetRestClient, BNetRestClient>();
            services.AddTransient<IUrlHelper, UrlHelper>();

            services.AddTransient<IBNetGuildClient, BNetGuildClient>();
            services.AddTransient<IBNetCharacterClient, BNetCharacterClient>();
            services.AddTransient<IBNetAccountClient, BNetAccountClient>();
        }
    }
}
