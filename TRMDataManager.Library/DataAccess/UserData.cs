using System.Collections.Generic;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<User> GetUserById(string id)
        {
            var sqlDataAccess = new SqlDataAccess();
            var parameters = new { Id = id };
            var user = sqlDataAccess.LoadData<User, dynamic>("[dbo].[spUserLookup]", parameters, "TRMData");
            return user;
        }
    }
}
