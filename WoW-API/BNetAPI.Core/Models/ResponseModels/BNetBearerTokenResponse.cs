using Newtonsoft.Json;

namespace BNetAPI.Core.Models.ResponseModels
{
    internal class BNetBearerTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int Expiration { get; set; }
    }
}
