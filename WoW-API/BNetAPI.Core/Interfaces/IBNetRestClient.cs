using BNetAPI.Core.Models;

namespace BNetAPI.Core.Interfaces
{
    public interface IBNetRestClient
    {
        Task<TResponse> GetFromBlizzardApiAsync<TResponse>(string endpoint, IBNetRequestModel request, string? token = null)
            where TResponse : IBaseResponse;

        Task<TResponse> PostToBlizzardApiAsync<TResponse>(string url, IDictionary<string, string> data)
            where TResponse : IBaseResponse;

        Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage)
            where TResponse : IBaseResponse;
    }
}
