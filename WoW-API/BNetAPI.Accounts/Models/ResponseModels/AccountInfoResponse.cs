using BNetAPI.Accounts.Models.ResponseModels.ResponseComponents;
using BNetAPI.Core.Models;
using Newtonsoft.Json;
using System.Net;

namespace BNetAPI.Accounts.Models.ResponseModels
{
    public class AccountInfoResponse : IBaseResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("wow_accounts")]
        public IEnumerable<AccountComponent>? Accounts { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
