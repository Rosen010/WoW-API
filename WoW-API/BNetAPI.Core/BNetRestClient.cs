using BNetAPI.Core.Interfaces;
using Newtonsoft.Json;

namespace BNetAPI.Core
{
    internal class BNetRestClient : IBNetRestClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IBNetApiClient _apiClient;
        private readonly IUrlHelper _urlHelper;

        public BNetRestClient(IHttpClientFactory clientFactory, IBNetApiClient apiClient, IUrlHelper urlHelper)
        {
            _clientFactory = clientFactory;
            _apiClient = apiClient;
            _urlHelper = urlHelper;
        }

        public async Task<TResponse> GetAsync<TResponse>(string endpoint, IBNetRequestModel request)
        {
            var url = _urlHelper.BuildBNetRequestUrl(endpoint, request);

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Authorization = await _apiClient.AuthenticateAsync();

                var response = await this.SendRequestAsync<TResponse>(httpRequest);
                return response;
            }
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