using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Sales.Campaigns;

namespace GameDemo.Sales.Campaigns
{
    class ProductCampaignManager : IProductCampaignService
    {
        public bool Discount(Product product)
        {
            if (product.Availibility==true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
