using BNetAPI.Guilds.Models.ResponseModels.ResponseComponents.Roster;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BNetAPI.Guilds.Models.ResponseModels
{
    public class RosterResponse
    {
        [JsonProperty("members")]
        public ICollection<MemberComponent> Members { get; set; }
    }
}
