using BNetAPI.Core.Interfaces;
using BNetAPI.Guilds.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Guilds
{
    public class GuildDependencyResolver : IDependencyRegistry
    {
        public void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IBNetGuildClient, BNetGuildClient>();
        }
    }
}
