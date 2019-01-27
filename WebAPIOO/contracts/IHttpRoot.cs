using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIOO.contracts
{
    public interface IHttpRoot
    {
        Task<IHttpResponse> GetAsync(Uri uri, string bearerToken);
        Task<IHttpResponse> PostAsync(Uri uri, string bearerToken, string contentType, Encoding encoding, Stream messageBody);

        // and Delete, Put, and others here
    }
}
