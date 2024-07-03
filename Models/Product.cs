using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }

        public Product() { }

        public Product(string name, string category, double price, string description, DateTime expireDate)
        {
            Name = name;
            Category = category;
            Price = price;
            Description = description;
            ExpireDate = expireDate;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}  {Price}");
        }

        public void ShowMoreInfo()
        {
            Console.WriteLine($"{Name}  {Price}  {Description} {ExpireDate.ToString("dd.MM.yyyy")}");
        }
    }
}
