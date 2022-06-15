namespace BNetAPI.Accounts.Interfaces
{
    public interface IBNetAccountClient
    {
        string GetAuthenticationUrl();

        Task<string> GetUserAccessTokenAsync(string code);
    }
}
