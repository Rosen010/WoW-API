using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Accounts.Models.ResponseModels.ResponseComponents
{
    public class RealmComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
