using BNetAPI.Accounts.Interfaces;
using BNetAPI.Accounts.Models.RequestModels;
using BNetAPI.Accounts.Models.ResponseModels;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;
using Microsoft.AspNetCore.WebUtilities;
using System.Web;

namespace BNetAPI.Accounts
{
    public class BNetAccountClient : IBNetAccountClient
    {
        private readonly IAuthorizationData _authData;
        private readonly IBNetRestClient _restClient;

        public BNetAccountClient(IAuthorizationData authData, IBNetRestClient restClient)
        {
            _authData = authData;
            _restClient = restClient;
        }

        public string GetAuthenticationUrl()
        {
            var endpoint = Endpoints.UserAuthentication;

            var requestData = new Dictionary<string, string>
                {
                    { RequestConstants.Parameters.ClientId, _authData.ClientId },
                    { RequestConstants.Parameters.Scope, RequestConstants.Scopes.WoWProfile },
                    { RequestConstants.Parameters.State, RequestConstants.StateValue },
                    { RequestConstants.Parameters.RedirectUri, "https://localhost:44379/profile/User/Info" },
                    { RequestConstants.Parameters.ResponseType, RequestConstants.ResponseTypes.Code },
                };

            var url = new Uri(QueryHelpers.AddQueryString(endpoint, requestData)).ToString();
            return url;
        }
    }
}