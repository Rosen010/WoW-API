using BNetAPI.Accounts.Models.ResponseModels.ResponseComponents;
using Newtonsoft.Json;

namespace BNetAPI.Accounts.Models.ResponseModels
{
    internal class AccountInfoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("wow_accounts")]
        public IEnumerable<AccountComponent> Accounts { get; set; }
    }
}
