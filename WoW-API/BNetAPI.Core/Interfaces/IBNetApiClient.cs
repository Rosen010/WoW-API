namespace BNetAPI.Core.Interfaces
{
    public interface IBNetApiClient
    {
        Task<string> FetchTokenAsync();
    }
}
