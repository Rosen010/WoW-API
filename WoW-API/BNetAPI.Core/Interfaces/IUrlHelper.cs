namespace BNetAPI.Core.Interfaces
{
    internal interface IUrlHelper
    {
        string BuildBNetRequestUrl(string endpoint, IBNetRequestModel request);
    }
}
