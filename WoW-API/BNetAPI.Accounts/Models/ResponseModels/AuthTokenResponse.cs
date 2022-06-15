using BNetAPI.Core.Models;
using Newtonsoft.Json;
using System.Net;

namespace BNetAPI.Accounts.Models.ResponseModels
{
    public class AuthTokenResponse : IBaseResponse
    {
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string? TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int Expiration { get; set; }

        [JsonProperty("scope")]
        public string? Scope { get; set; }

        [JsonProperty("sub")]
        public string? Sub { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
