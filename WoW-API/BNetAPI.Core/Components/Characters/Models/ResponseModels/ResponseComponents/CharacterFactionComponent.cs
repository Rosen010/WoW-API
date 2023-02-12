using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Characters.Models.ResponseModels.ResponseComponents
{
    public class CharacterFactionComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
