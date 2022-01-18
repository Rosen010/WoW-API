using BNetAPI.Core.Models;

namespace BNetAPI.Core.Interfaces
{
    public interface IBNetApiClient
    {
        Task<string> FetchTokenAsync(AuthorizationData authData);
    }
}
