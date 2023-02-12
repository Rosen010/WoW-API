using BNetAPI.Core.Components.Guilds.Models.ResponseModels.ResponseComponents.Roster;
using BNetAPI.Core.Models;

using Newtonsoft.Json;

using System.Net;

namespace BNetAPI.Core.Components.Guilds.Models.ResponseModels
{
    public class RosterResponse : IBaseResponse
    {
        [JsonProperty("members")]
        public ICollection<MemberComponent> Members { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
