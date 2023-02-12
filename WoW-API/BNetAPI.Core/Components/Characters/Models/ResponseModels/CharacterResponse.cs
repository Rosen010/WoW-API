using BNetAPI.Core.Components.Characters.Models.ResponseModels.ResponseComponents;
using BNetAPI.Core.Models;

using Newtonsoft.Json;

using System.Net;

namespace BNetAPI.Core.Components.Characters.Models.ResponseModels
{
    public class CharacterResponse : IBaseResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faction")]
        public CharacterFactionComponent Faction { get; set; }

        [JsonProperty("race")]
        public CharacterBaseResponseComponent Race { get; set; }

        [JsonProperty("character_class")]
        public CharacterBaseResponseComponent Class { get; set; }

        [JsonProperty("active_spec")]
        public CharacterBaseResponseComponent Spec { get; set; }

        [JsonProperty("realm")]
        public CharacterBaseResponseComponent Realm { get; set; }

        [JsonProperty("guild")]
        public CharacterBaseResponseComponent Guild { get; set; }

        [JsonProperty("average_item_level")]
        public int AvgItemLevel { get; set; }
        
        [JsonProperty("equipped_item_level")]
        public int EquippedItemLevel { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
