using System.Net.Http.Headers;

namespace BNetAPI.Core.Interfaces
{
    public interface IBNetApiClient
    {
        Task<AuthenticationHeaderValue> AuthenticateAsync();

        Task<string> FetchTokenAsync();
    }
}
