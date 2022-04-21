using BNetAPI.Core.Models;
using BNetAPI.Guilds.Models.ResponseModels.ResponseComponents.Roster;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Net;

namespace BNetAPI.Guilds.Models.ResponseModels
{
    public class RosterResponse : IBaseResponse
    {
        [JsonProperty("members")]
        public ICollection<MemberComponent> Members { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
