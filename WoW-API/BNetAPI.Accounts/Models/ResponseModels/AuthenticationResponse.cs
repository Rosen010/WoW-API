using BNetAPI.Core.Models;
using System.Net;

namespace BNetAPI.Accounts.Models.ResponseModels
{
    public class AuthenticationResponse : IBaseResponse
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
