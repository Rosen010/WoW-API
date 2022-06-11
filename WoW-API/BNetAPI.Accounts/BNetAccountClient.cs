using BNetAPI.Accounts.Interfaces;
using BNetAPI.Accounts.Models.RequestModels;
using BNetAPI.Accounts.Models.ResponseModels;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;

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

        public async Task AuthenticateUser(AuthenticationRequestModel requestModel)
        {
            var endpoint = string.Format(Endpoints.UserAuthentication, requestModel?.Region);

            if (requestModel != null)
            {
                var requestData = new Dictionary<string, string>
                {
                    { RequestConstants.Parameters.ClientId, _authData.ClientId },
                    { RequestConstants.Parameters.Scope, RequestConstants.Scopes.WoWProfile },
                    { RequestConstants.Parameters.State, requestModel.State },
                    { RequestConstants.Parameters.RedirectUri, "http://localhost:44379" },
                    { RequestConstants.Parameters.ResponseType, RequestConstants.ResponseTypes.Code },
                };

                await _restClient.GetAsync<AuthenticationResponse>(endpoint, requestData);
            }
        }
    }
}