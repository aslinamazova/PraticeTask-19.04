using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04Pratice.Models
{
    public class Shop
    {
        public static int Id { get; set; }
        public string Title { get; set; }

        Product[] products = new Product[0];

        public Product AddProduct(Product product)
        {
            products[0] = product;
            return products[0];
        }
        public Product GetProduct(int id)
        {
            return products[id];

        }
        public Product GetInStockProducts(Product product)
        {
            return product;
        }

    }
}
