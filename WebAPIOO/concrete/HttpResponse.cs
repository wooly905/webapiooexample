using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    public class HttpResponse : IHttpResponse
    {
        // accept response
        public HttpResponse()
        {
            // parsing response body
        }

        public HttpStatusCode StatusCode
        {
            get
            {
                // get the result from stream
                return HttpStatusCode.OK;
            }
        }

        public IEnumerable<string> GetHeader(string name)
        {
            // get the result from stream
            return new List<string>() { "Header1=ok" };
        }

        public Task<Stream> GetResponseBodyAsync()
        {
            // handling response stream here
            return Task.FromResult<Stream>(null);
        }
    }
}
