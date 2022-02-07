using Newtonsoft.Json;

namespace BNetAPI.Guilds.Models.ResponseModels.ResponseComponents.Roster
{
    public class MemberComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playable_class")]
        public ClassComponent Class { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
