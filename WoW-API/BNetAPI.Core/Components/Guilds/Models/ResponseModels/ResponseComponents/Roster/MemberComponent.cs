using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Guilds.Models.ResponseModels.ResponseComponents.Roster
{
    public class MemberComponent
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("character")]
        public CharacterComponent Character { get; set; }
    }
}
