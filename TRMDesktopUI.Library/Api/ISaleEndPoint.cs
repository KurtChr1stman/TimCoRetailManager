using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;
using TRNDataManager.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface ISaleEndPoint
    {
        Task PostSale(SaleModel sale);
    }
}