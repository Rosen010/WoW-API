using BNetAPI.Accounts.Models.RequestModels;

namespace BNetAPI.Accounts.Interfaces
{
    public interface IBNetAccountClient
    {
        Task AuthenticateUser(AuthenticationRequestModel requestModel);
    }
}
