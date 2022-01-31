using BNetAPI.Core.Interfaces;

namespace BNetAPI.Core.Models
{
    public class AuthorizationData : IAuthorizationData
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
    }
}
