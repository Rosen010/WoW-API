using BNetAPI.Core.Interfaces;
using BNetAPI.Guilds.Interfaces;

namespace BNetAPI.Guilds
{
    internal class BNetGuildClient : IBNetGuildClient
    {
        private readonly IBNetApiClient _apiClient;

        private readonly IBNetRestClient _restClient;

        public BNetGuildClient(IBNetApiClient apiClient, IBNetRestClient _restClient)
        {

        }
    }
}
