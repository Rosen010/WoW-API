using Newtonsoft.Json;

namespace BNetAPI.Characters.Models.ResponseModels.ResponseComponents
{
    public class CharacterBaseResponseComponent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
