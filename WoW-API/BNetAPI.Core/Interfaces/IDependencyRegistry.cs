using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Core.Interfaces
{
    public interface IDependencyRegistry
    {
        public void RegisterDependencies(IServiceCollection services);
    }
}
