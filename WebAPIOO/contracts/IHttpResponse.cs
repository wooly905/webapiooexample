using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WebAPIOO.contracts
{
    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }
        Task<Stream> GetResponseBodyAsync();
        IEnumerable<string> GetHeader(string name);
    }
}
