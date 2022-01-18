using BNetAPI.Core.Interfaces;
using Newtonsoft.Json;

namespace BNet.RestAPI
{
    internal class BNetRestClient : IBNetRestClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public BNetRestClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage)
        {
            var client = _clientFactory.CreateClient();

            using (var httpResponse = await client.SendAsync(requestMessage))
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TResponse>(json);

                return response;
            }
        }
    }
}