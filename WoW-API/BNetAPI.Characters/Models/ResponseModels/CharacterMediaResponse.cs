using BNetAPI.Characters.Models.ResponseModels.ResponseComponents;
using Newtonsoft.Json;

namespace BNetAPI.Characters.Models.ResponseModels
{
    public class CharacterMediaResponse
    {
        [JsonProperty("assets")]
        public ICollection<CharacterAssetComponent> Assets { get; set; }
    }
}
