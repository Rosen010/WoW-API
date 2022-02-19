using BNetAPI.Core.Enums;
using BNetAPI.Core.Interfaces;
using System.Web;

namespace BNetAPI.Core.Helpers
{
    internal class UrlHelper
    {
        public string BuildBNetRequestUrl(string endpoint, IBNetRequestModel request)
        {
            var builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);

            query[BNetRequestHeaders.Namespace.ToString().ToLower()] = request.NameSpace;
            query[BNetRequestHeaders.Locale.ToString().ToLower()] = request.Locale;

            builder.Query = query.ToString();
            return builder.ToString();
        }
    }
}
