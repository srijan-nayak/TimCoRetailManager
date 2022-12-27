using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TRMDesktopUI.Ibrary.Models;
using TRMDesktopUI.Library.Api;

namespace TRMDesktopUI.Ibrary.Api
{
    public class ProductEndpoint : IProductEndpoint
    {
        private IAPIHelper _apiHelper;

        public ProductEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<Product>> GetAll()
        {
            using (var response = await _apiHelper.ApiClient.GetAsync("/api/Product"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<Product>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
