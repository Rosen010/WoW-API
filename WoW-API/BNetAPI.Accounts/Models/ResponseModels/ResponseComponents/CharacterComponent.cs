using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels.ResponseComponents
{
    public class CharacterComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realm")]
        public RealmComponent Realm { get; set; }

        [JsonProperty("playable_class")]
        public ClassComponent Class { get; set; }

        [JsonProperty("playable_race")]
        public RaceComponent Race { get; set; }

        [JsonProperty("gender")]
        public GenderComponent Gender { get; set; }

        [JsonProperty("faction")]
        public FactionComponent Faction { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }
    }
}
