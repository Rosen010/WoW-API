using BNetAPI.Guilds.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Guilds
{
    public static class GuildDependencyResolver
    {
        public static void AddBNetGuilds(this IServiceCollection services)
        {
            services.AddTransient<IBNetGuildClient, BNetGuildClient>();
        }
    }
}
