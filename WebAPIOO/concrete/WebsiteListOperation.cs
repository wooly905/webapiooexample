using System;
using System.Net;
using System.Threading.Tasks;
using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    public class WebsiteListOperation : EntityBase, IWebsiteListOperation
    {
        private const string _operationName = "WebsiteList";
        private readonly IHttpRoot _httpRoot;

        public WebsiteListOperation(Uri parentUri, IHttpRoot httpRoot)
            : base(parentUri)
        {
            _httpRoot = httpRoot;
        }

        public Uri GetUri()
        {
            return GetNewUri(_operationName);
        }

        public async Task<IWebsiteListOperationResult> GetResultAsync()
        {
            IHttpResponse response = await _httpRoot.GetAsync(GetUri(), "token-string-here").ConfigureAwait(false);

            if (response == null)
            {
                throw new Exception("No result");
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"HttpStatus Code is {response.StatusCode}");
            }

            // parse stream and assign all data to result
            // Stream stream = await response.GetResponseBodyAsync().ConfigureAwait(false);
            WebsiteListOperationResult result = new WebsiteListOperationResult(new string[] { "website1", "website2" });

            return result;
        }
    }

}
