using BNetAPI.Core.Utilities.Constants;

namespace BNetAPI.Accounts.Models.RequestModels
{
    public class AuthenticationRequestModel
    {
        public string? ClientId { get; set; }

        public string? Scope { get; set; }

        public string State => RequestConstants.StateValue;

        public string? RedirectUri { get; set; }

        public string? ResponseType { get; set; }

        public string? Region { get; set; }
    }
}
