using System;
using System.Threading.Tasks;
using WebAPIOO.concrete;
using WebAPIOO.contracts;

namespace WebAPIOO
{
    class Program
    {
        //  http://machine/RootGroup/WebsiteGroup/WebsiteList

        static async Task Main(string[] args)
        {
            IHttpRoot httpRoot = CreateHttpRoot();
            IRootGroup rootGroup = CreateRootGroup(httpRoot);
            ISubGroup websiteGroup = rootGroup.GetSubGroup<WebsiteGroup>();

            if (websiteGroup == null)
            {
                return;
            }

            IWebsiteListOperation websiteListOperation = websiteGroup.GetOperation<WebsiteListOperation>();

            if (websiteListOperation == null)
            {
                return;
            }

            IWebsiteListOperationResult websiteListResult = await websiteListOperation.GetResultAsync().ConfigureAwait(false);

            if (websiteListResult == null)
            {
                return;
            }

            for (int i = 0; i < websiteListResult.WebsiteList.Length; i++)
            {
                Console.WriteLine(websiteListResult.WebsiteList[i]);
            }
            
            Console.ReadLine();
        }

        private static IHttpRoot CreateHttpRoot()
        {
            // initialize the object for HttpClient
            return new HttpRoot();
        }

        private static IRootGroup CreateRootGroup(IHttpRoot root)
        {
            // initilize the object for root
            return new RootGroup(root);
        }
    }
}
