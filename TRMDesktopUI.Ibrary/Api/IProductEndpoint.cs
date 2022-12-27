using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUI.Ibrary.Models;

namespace TRMDesktopUI.Ibrary.Api
{
    public interface IProductEndpoint
    {
        Task<List<Product>> GetAll();
    }
}