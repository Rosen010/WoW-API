using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Accounts.Models.ResponseModels.ResponseComponents
{
    public class RaceComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
