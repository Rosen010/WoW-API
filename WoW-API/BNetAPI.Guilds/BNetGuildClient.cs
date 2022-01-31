using BNetAPI.Core.Enums;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;
using BNetAPI.Guilds.Interfaces;
using BNetAPI.Guilds.Models.RequestModels;
using BNetAPI.Guilds.Models.ResponseModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Web;

namespace BNetAPI.Guilds
{
    internal class BNetGuildClient : IBNetGuildClient
    {
        private readonly IBNetApiClient _apiClient;

        private readonly IBNetRestClient _restClient;

        public BNetGuildClient(IBNetApiClient apiClient, IBNetRestClient restClient)
        {
            _apiClient = apiClient;
            _restClient = restClient;
        }

        public async Task<GuildResponse> RetrieveGuild(GuildRequestModel request)
        {
            var token = await _apiClient.FetchTokenAsync();
            var endpoint = string.Format(Endpoints.Guild, request.Realm, request.GuildName);

            var builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);

            query[BNetRequestHeaders.Namespace.ToString()] = request.NameSpace;
            query[BNetRequestHeaders.Locale.ToString()] = request.Locale;

            builder.Query = query.ToString();
            var url = builder.ToString();

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Authorization = new AuthenticationHeaderValue(ApiRequestConstants.AuthenticationType.Bearer, token);

                var response = await _restClient.SendRequestAsync<GuildResponse>(httpRequest);
                return response;
            }
        }
    }
}
