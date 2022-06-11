using BNetAPI.Accounts.Interfaces;
using BNetAPI.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Accounts
{
    public class AccountDependencyResolver : IDependencyRegistry
    {
        public void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IBNetAccountClient, BNetAccountClient>();
        }
    }
}
