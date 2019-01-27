using WebAPIOO.contracts;

namespace WebAPIOO.concrete
{
    // data structure of the result of WebsiteList api
    public class WebsiteListOperationResult : IWebsiteListOperationResult
    {
        public WebsiteListOperationResult(string[] list)
        {
            WebsiteList = list;
        }

        public string[] WebsiteList { get; }
    }
}
