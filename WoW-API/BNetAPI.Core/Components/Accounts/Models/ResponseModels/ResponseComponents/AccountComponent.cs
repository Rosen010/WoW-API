using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Accounts.Models.ResponseModels.ResponseComponents
{
    public class AccountComponent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("characters")]
        public IEnumerable<CharacterComponent> Characters { get; set; }
    }
}
