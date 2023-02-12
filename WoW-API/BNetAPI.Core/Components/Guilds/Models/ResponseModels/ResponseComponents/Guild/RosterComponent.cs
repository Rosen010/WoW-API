using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Guilds.Models.ResponseModels.ResponseComponents
{
    public class RosterComponent
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
