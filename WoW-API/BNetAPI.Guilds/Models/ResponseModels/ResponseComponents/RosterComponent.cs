using Newtonsoft.Json;

namespace BNetAPI.Guilds.Models.ResponseModels.ResponseComponents
{
    public class RosterComponent
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
