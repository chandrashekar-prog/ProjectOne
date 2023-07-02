using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {           
                new Product()
                {
                    ProductId = 1,
                    Name = "Product 1",
                    Price = (decimal)499.99
                }               
            };
         for (int i = 2; i <= 10; i++)
            {
                products.Add(new Product
                {
                    ProductId=i,
                    Name="Product "+ i,
                    Price=(decimal)(i*150+0.59)+((decimal)i/12)
                });
            }


            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.Slug == slug);
            //foreach (Product p in products)
            //{
            //    if (p.Slug == slug)
            //    {
            //        return p;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}  
         return product;
        }

    }
}
