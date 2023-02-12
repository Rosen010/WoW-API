using BNetAPI.Core.Components.Guilds.Models.RequestModels;
using BNetAPI.Core.Components.Guilds.Models.ResponseModels;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;


namespace BNetAPI.Core.Components.Guilds
{
    internal class BNetGuildClient : IBNetGuildClient
    {
        private readonly IBNetRestClient _restClient;

        public BNetGuildClient(IBNetRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<GuildResponse> RequestGuildAsync(GuildRequestModel request)
        {
            var endpoint = string.Format(Endpoints.Guild, request.Region, request.Realm, request.GuildName);
            return await _restClient.GetFromBlizzardApiAsync<GuildResponse>(endpoint, request);
        }

        public async Task<RosterResponse> RequestRosterAsync(RosterRequestModel request)
        {
            var endpoint = string.Format(Endpoints.Roster, request.Region, request.Realm, request.GuildName);
            return await _restClient.GetFromBlizzardApiAsync<RosterResponse>(endpoint, request);
        }
    }
}
