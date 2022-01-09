using System.Net.Http;
using System.Threading.Tasks;

namespace BNet.RestAPI.Interfaces
{
    public interface IBNetRestClient
    {
        Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage);
    }
}
