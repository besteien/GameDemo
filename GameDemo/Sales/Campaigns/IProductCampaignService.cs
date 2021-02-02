using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Sales.Campaigns;

namespace GameDemo.Sales.Campaigns
{
    interface IProductCampaignService
    {
        bool Discount(Product product);
    }
}
