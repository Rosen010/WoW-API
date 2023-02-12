using BNetAPI.Core.Components.Accounts.Models.ResponseModels;

namespace BNetAPI.Accounts.Interfaces
{
    public interface IBNetAccountClient
    {
        string GetAuthenticationUrl();

        Task<string?> GetUserAccessTokenAsync(string code);

        Task<AccountInfoResponse> GetUserAccountInfo(string token);
    }
}
