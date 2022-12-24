using System.Collections.Generic;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<Product> GetProducts()
        {
            var sqlDataAccess = new SqlDataAccess();
            var products = sqlDataAccess.LoadData<Product, dynamic>("[dbo].[spProduct_GetAll]", new { }, "TRMData");
            return products;
        }
    }
}
