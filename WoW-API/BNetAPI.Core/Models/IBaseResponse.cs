using System.Net;

namespace BNetAPI.Core.Models
{
    public interface IBaseResponse
    {
        HttpStatusCode StatusCode { get; set; }
    }
}
