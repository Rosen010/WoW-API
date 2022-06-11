using BNetAPI.Core.Models;

namespace BNetAPI.Core.Interfaces
{
    public interface IBNetRestClient
    {
        Task<TResponse> GetAsync<TResponse>(string endpoint, IBNetRequestModel request)
            where TResponse : IBaseResponse;

        Task<TResponse> GetAsync<TResponse>(string endpoint, IDictionary<string, string> data)
            where TResponse : IBaseResponse;

        Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage)
            where TResponse : IBaseResponse;
    }
}
