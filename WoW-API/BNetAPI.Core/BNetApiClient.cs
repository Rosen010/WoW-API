using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;
using BNetAPI.Core.Models.ResponseModels;
using Microsoft.Extensions.Caching.Memory;
using System.Text;
using System.Net.Http.Headers;

namespace BNetAPI.Core
{
    internal class BNetApiClient : IBNetApiClient
    {
        private readonly IMemoryCache _cache;
        private readonly IBNetRestClient _restClient;
        private readonly IAuthorizationData _authData;

        public BNetApiClient(IMemoryCache cache, IBNetRestClient restClient, IAuthorizationData authData)
        {
            _cache = cache;
            _restClient = restClient;
            _authData = authData;
        }

        public async Task<AuthenticationHeaderValue> AuthenticateAsync()
        {
            var token = await this.FetchTokenAsync();
            
            if (!string.IsNullOrEmpty(token))
            {
                return new AuthenticationHeaderValue(ApiRequestConstants.AuthenticationType.Bearer, token);
            }

            return null;
        }

        public async Task<string> FetchTokenAsync()
        {
            var token = string.Empty;

            if (!_cache.TryGetValue(AuthorizationConstants.AccessTokenName, out token))
            {
                using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, Endpoints.BNetOauth))
                {
                    var credentials = Convert.ToBase64String(
                        Encoding.ASCII.GetBytes(string.Format(Formats.ColonSeparatedKVPFormat, _authData.ClientId, _authData.ClientSecret)));

                    var data = new Dictionary<string, string>
                    {
                        { ApiRequestConstants.Headers.GrantType, ApiRequestConstants.GrantTypes.ClientCredentials },
                    };

                    httpRequest.Headers.Authorization = new AuthenticationHeaderValue(ApiRequestConstants.AuthenticationType.Basic, credentials);
                    httpRequest.Content = new FormUrlEncodedContent(data);

                    var response = await _restClient.SendRequestAsync<BNetBearerTokenResponse>(httpRequest);
                    this.CacheToken(response);

                    token = response.AccessToken;
                }
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
