using BNetAPI.Characters.Models.Interfaces;
using BNetAPI.Characters.Models.RequestModels;
using BNetAPI.Characters.Models.ResponseModels;
using BNetAPI.Core.Enums;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;
using System.Net.Http.Headers;
using System.Web;

namespace BNetAPI.Characters
{
    public class BNetCharacterClient : IBNetCharacterClient
    {
        private readonly IBNetApiClient _apiClient;

        private readonly IBNetRestClient _restClient;

        public BNetCharacterClient(IBNetApiClient apiClient, IBNetRestClient restClient)
        {
            _apiClient = apiClient;
            _restClient = restClient;
        }

        public async Task<CharacterResponse> RequestCharacterAsync(CharacterRequestModel request)
        {
            var token = await _apiClient.FetchTokenAsync();
            var endpoint = string.Format(Endpoints.Character, request.Realm, request.CharacterName);

            var builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);

            query[BNetRequestHeaders.Namespace.ToString().ToLower()] = request.NameSpace;
            query[BNetRequestHeaders.Locale.ToString().ToLower()] = request.Locale;

            builder.Query = query.ToString();
            var url = builder.ToString();

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Authorization = new AuthenticationHeaderValue(ApiRequestConstants.AuthenticationType.Bearer, token);

                var response = await _restClient.SendRequestAsync<CharacterResponse>(httpRequest);
                return response;
            }
        }

        public async Task<CharacterMediaResponse> RequestCharacterMediaAsync(CharacterRequestModel request)
        {
            var token = await _apiClient.FetchTokenAsync();
            var endpoint = string.Format(Endpoints.CharacterMedia, request.Realm, request.CharacterName);

            var builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);

            query[BNetRequestHeaders.Namespace.ToString().ToLower()] = request.NameSpace;
            query[BNetRequestHeaders.Locale.ToString().ToLower()] = request.Locale;

            builder.Query = query.ToString();
            var url = builder.ToString();

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Authorization = new AuthenticationHeaderValue(ApiRequestConstants.AuthenticationType.Bearer, token);

                var response = await _restClient.SendRequestAsync<CharacterMediaResponse>(httpRequest);
                return response;
            }
        }
    }
}
