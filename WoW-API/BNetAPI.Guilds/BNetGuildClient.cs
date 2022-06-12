using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;
using BNetAPI.Guilds.Interfaces;
using BNetAPI.Guilds.Models.RequestModels;
using BNetAPI.Guilds.Models.ResponseModels;
using System.Threading.Tasks;

namespace BNetAPI.Guilds
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
