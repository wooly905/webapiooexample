using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    public class HttpRoot : IHttpRoot
    {
        public Task<IHttpResponse> GetAsync(Uri uri, string bearerToken)
        {
            // call HttpClient here and get response here
            return Task.FromResult<IHttpResponse>(new HttpResponse());
        }

        public Task<IHttpResponse> PostAsync(Uri uri, string bearerToken, string contentType, Encoding encoding, Stream messageBody)
        {
            // call HttpClient here and get response here
            return Task.FromResult<IHttpResponse>(null);
        }

        // add Delete, Put, and so on ...
    }
}
