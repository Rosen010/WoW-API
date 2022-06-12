using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Models;
using BNetAPI.Core.Models.ResponseModels;
using BNetAPI.Core.Utilities.Constants;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BNetAPI.Core
{
    internal class BNetRestClient : IBNetRestClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IUrlHelper _urlHelper;
        private readonly IMemoryCache _cache;
        private readonly IAuthorizationData _authData;

        public BNetRestClient(IHttpClientFactory clientFactory, IUrlHelper urlHelper, IMemoryCache cache, IAuthorizationData authData)
        {
            _clientFactory = clientFactory;
            _urlHelper = urlHelper;
            _cache = cache;
            _authData = authData;
        }

        public async Task<TResponse> GetFromBlizzardApiAsync<TResponse>(string endpoint, IBNetRequestModel request)
            where TResponse : IBaseResponse
        {
            var url = _urlHelper.BuildBNetRequestUrl(endpoint, request);

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Authorization = await this.AuthenticateAsync();

                var response = await this.SendRequestAsync<TResponse>(httpRequest);
                return response;
            }
        }

        public async Task<TResponse> PostToBlizzardApiAsync<TResponse>(string url, IDictionary<string, string> data)
            where TResponse : IBaseResponse
        {
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, url))
            {
                var credentials = Convert.ToBase64String(
                       Encoding.ASCII.GetBytes(string.Format(Formats.ColonSeparatedKVPFormat, _authData.ClientId, _authData.ClientSecret)));

                httpRequest.Headers.Authorization = new AuthenticationHeaderValue(RequestConstants.AuthenticationType.Basic, credentials);
                httpRequest.Content = new FormUrlEncodedContent(data);

                var response = await this.SendRequestAsync<TResponse>(httpRequest);
                return response;
            }
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage requestMessage)
            where TResponse : IBaseResponse
        {
            var client = _clientFactory.CreateClient();

            using (var httpResponse = await client.SendAsync(requestMessage))
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TResponse>(json);
                response.StatusCode = httpResponse.StatusCode;

                return response;
            }
        }

        private async Task<AuthenticationHeaderValue> AuthenticateAsync()
        {
            var token = await this.FetchTokenAsync();

            if (!string.IsNullOrEmpty(token))
            {
                return new AuthenticationHeaderValue(RequestConstants.AuthenticationType.Bearer, token);
            }

            return null;
        }

        private async Task<string> FetchTokenAsync()
        {
            var token = string.Empty;

            if (!_cache.TryGetValue(AuthorizationConstants.AccessTokenName, out token))
            {
                var data = new Dictionary<string, string>
                {
                    { RequestConstants.Parameters.GrantType, RequestConstants.GrantTypes.ClientCredentials },
                };

                var response = await this.PostToBlizzardApiAsync<BNetBearerTokenResponse>(Endpoints.BNetOauth, data);
                token = response.AccessToken;
                this.CacheToken(response);
            }

            return token;
        }

        private void CacheToken(BNetBearerTokenResponse response)
        {
            var options = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(response.Expiration));
            _cache.Set(AuthorizationConstants.AccessTokenName, response.AccessToken, options);
        }
    }
}