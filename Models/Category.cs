
namespace Market.Models
{
    internal class Category
    {
        public string Name { get; set; }

        public List<Product> products = new List<Product>();

        public Category() { }   

        public Category(string name)
        { 
            Name = name; 
        }
        
    }
}
