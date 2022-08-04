using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels.ResponseComponents
{
    public class GenderComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
