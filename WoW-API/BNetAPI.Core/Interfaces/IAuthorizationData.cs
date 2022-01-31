namespace BNetAPI.Core.Interfaces
{
    public interface IAuthorizationData
    {
        string ClientId { get; set; }

        string ClientSecret { get; set; }
    }
}
