using BNetAPI.Core.Components.Characters.Models.ResponseModels.ResponseComponents;
using BNetAPI.Core.Models;

using Newtonsoft.Json;

using System.Net;

namespace BNetAPI.Core.Components.Characters.Models.ResponseModels
{
    public class CharacterMediaResponse : IBaseResponse
    {
        [JsonProperty("assets")]
        public ICollection<CharacterAssetComponent> Assets { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
