using BNetAPI.Characters.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Characters
{
    public static class CharactersDependencyResolver
    {
        public static void AddBNetCharacters(this IServiceCollection services)
        {
            services.AddTransient<IBNetCharacterClient, BNetCharacterClient>();
        }
    }
}
