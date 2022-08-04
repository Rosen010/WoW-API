using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels.ResponseComponents
{
    public class FactionComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
