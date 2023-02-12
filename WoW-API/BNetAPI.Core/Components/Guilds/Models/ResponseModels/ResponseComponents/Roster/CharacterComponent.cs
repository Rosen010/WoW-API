using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Guilds.Models.ResponseModels.ResponseComponents.Roster
{
    public class CharacterComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playable_class")]
        public ClassComponent Class { get; set; }
    }
}
