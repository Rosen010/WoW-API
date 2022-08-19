using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels.ResponseComponents
{
    public class ClassComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
