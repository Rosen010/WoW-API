using BNetAPI.Core.Models;
using BNetAPI.Guilds.Models.ResponseModels.ResponseComponents;

using Newtonsoft.Json;

using System.Net;

namespace BNetAPI.Guilds.Models.ResponseModels
{
    public class GuildResponse : IBaseResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_count")]
        public int MembersCount { get; set; }

        [JsonProperty("realm")]
        public RealmComponent Realm { get; set; }

        [JsonProperty("roster")]
        public RosterComponent RosterUrl { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedOn { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
