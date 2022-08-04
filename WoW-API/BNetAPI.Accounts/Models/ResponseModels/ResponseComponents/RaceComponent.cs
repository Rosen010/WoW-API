using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels.ResponseComponents
{
    public class RaceComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
