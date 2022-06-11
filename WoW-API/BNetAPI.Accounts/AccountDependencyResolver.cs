using BNetAPI.Accounts.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BNetAPI.Accounts
{
    public static class AccountDependencyResolver
    {
        public static void AddBNetAccounts(this IServiceCollection services)
        {
            services.AddTransient<IBNetAccountClient, BNetAccountClient>();
        }
    }
}
