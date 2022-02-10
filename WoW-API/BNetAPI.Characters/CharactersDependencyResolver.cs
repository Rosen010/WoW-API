using BNetAPI.Characters.Models.Interfaces;
using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Characters
{
    public class CharactersDependencyResolver : IDependencyRegistry
    {
        public void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IBNetCharacterClient, BNetCharacterClient>();
        }
    }
}
