using Newtonsoft.Json;

using System.Net;

namespace BNetAPI.Core.Models.ResponseModels
{
    internal class BNetBearerTokenResponse : IBaseResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int Expiration { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
