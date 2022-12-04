using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_HOL2.Models
{
    public class products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Prince { get; set; }
        public IEnumerable<products> GetProducts()
        {
            return new List<products>()
            {
            new products ProductId=1, ProductName = "Product1", Price = 900.00 },
            new products { ProductId = 2, ProductName = "Product2" Price = 700.00},
            new products { ProductId = 3, ProductName ="roduct3, Price = 650.00 },
                new products { ProductId = 4, ProductName = "Product4, Price = 950.00 },
                new products { ProductId = 5, ProductName = "Product5, Price = 800.00 },


                };
            }
             
    }
}