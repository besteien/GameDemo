using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Sales
{
    interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
