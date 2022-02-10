using Newtonsoft.Json;

namespace BNetAPI.Characters.Models.ResponseModels.ResponseComponents
{
    public class CharacterFactionComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
