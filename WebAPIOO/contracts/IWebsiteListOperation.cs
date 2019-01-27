using System.Threading.Tasks;

namespace WebAPIOO.contracts
{
    public interface IWebsiteListOperation : IWebsiteOperation
    {
        Task<IWebsiteListOperationResult> GetResultAsync();
    }
}
