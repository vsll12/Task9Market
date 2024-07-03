using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    internal class Bucket
    {
        public List<Product>? products;

        public void Add(Product product)
        {
            products?.Add(product);
        }

        public void Delete(Product product)
        {
            products?.Remove(product);
        }

        public void ShowInfo()
        {
            foreach ( var prod in products)
            {
                int i = 1;
                Console.WriteLine($" {i}.{prod.Name}  {prod.Price}");
            }
        }
    }
}
