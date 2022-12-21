using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public User GetById()
        {
            var userId = RequestContext.Principal.Identity.GetUserId();
            var userData = new UserData();
            return userData.GetUserById(userId).First();
        }
    }
}
