namespace BNetAPI.Core.Interfaces
{
    public interface IBNetRestClient
    {
        Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage);
    }
}
