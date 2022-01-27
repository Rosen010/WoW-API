using Newtonsoft.Json;

namespace BNetAPI.Guilds.Models.ResponseModels.ResponseComponents
{
    public class KeyComponent
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
