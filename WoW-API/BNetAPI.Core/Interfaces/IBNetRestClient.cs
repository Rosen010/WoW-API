namespace BNetAPI.Core.Interfaces
{
    public interface IBNetRestClient
    {
        Task<TResponse> GetAsync<TResponse>(string endpoint, IBNetRequestModel request);

        Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage);
    }
}
