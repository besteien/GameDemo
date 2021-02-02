using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Sales;
using GameDemo.Sales.Campaigns;

namespace GameDemo
{
    class Program
    {
        public static int ProductPrice { get; private set; }
        public static bool Availibity { get; private set; }

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                BirthYear = 1998, 
                FirstName = "BESTE", 
                LastName="DÜLGER", 
                NationalIdentityNumber= 1111111111
            });

            ProductManager productManager = new ProductManager(new ProductCampaignManager());
            productManager.Update(new Product { Availibility = true, ProductPrice = 100 });
        }
    }
}
