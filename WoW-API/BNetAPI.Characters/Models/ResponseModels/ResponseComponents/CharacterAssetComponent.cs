using Newtonsoft.Json;

namespace BNetAPI.Characters.Models.ResponseModels.ResponseComponents
{
    public class CharacterAssetComponent
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
