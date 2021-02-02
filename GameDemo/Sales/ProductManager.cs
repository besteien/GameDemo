using GameDemo.Sales.Campaigns;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Sales
{
    class ProductManager : IProductService
    {
        IProductCampaignService _productCampaignService;
        public ProductManager(IProductCampaignService productCampaignService)
        {
            _productCampaignService = productCampaignService;
        }

        public void Add(Product product)
        {
            Console.WriteLine("New Product has been added!");
        }

        public void Update(Product product)
        {
            if (_productCampaignService.Discount(product) == true)
            {
                Console.WriteLine("Product has been updated! " + "New Price: " + product.ProductPrice * 0.5);
            }
            else
            {
                Console.WriteLine("Product is currently not available!");
            }
        }

        private static bool GetAvailibility(Product product)
        {
            return product.Availibility;
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product has been deleted!");
        }
    }
}
