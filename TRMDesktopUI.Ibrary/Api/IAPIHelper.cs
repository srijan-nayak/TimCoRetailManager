using System.Threading.Tasks;
using TRMDesktopUI.Ibrary.Models;

namespace TRMDesktopUI.Ibrary.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}