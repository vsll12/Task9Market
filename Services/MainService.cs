using Market.Models;

namespace Market.Services
{
    internal class MainService
    {
        Product product1 = new Product("Name1", "Category1", 23.4, "Descroption", DateTime.Now);
        Product product2 = new Product("Name2", "Category1", 23.4, "Descroption", DateTime.Now);
        Product product3 = new Product("Name3", "Category2", 23.4, "Descroption", DateTime.Now);

        Category category1 = new Category("Category1");
        Category category2 = new Category("Category2");
        

        User? User;

        UserLoginService userLoginService = new UserLoginService();

        List<Category> categories = new List<Category>();

        public void Initialize()
        {

            category1.products.Add(product1);
            category1.products.Add(product2);
            category2.products.Add(product3);

            categories.Add(category1);
            categories.Add(category2);

        }

        public void Start()
        {
            string choice;
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.Write("Enter your choice : ");
            choice = Console.ReadLine();
            if(choice == "1" ) 
            {
                if(userLoginService.CheckForLogin() != null) 
                {
                    User = userLoginService.CheckForLogin();
                    foreach(var category in categories) 
                    {
                        int i = 0;
                        Console.WriteLine($"{i + 1}.{category.Name}");
                    }
                    int choice_for_category;
                    Console.Write("Choice : ");
                    choice_for_category = int.Parse(Console.ReadLine());
                    for(int i =  0; i < categories.Count(); i++)
                    {
                        if (categories[i].Name == categories[choice_for_category - 1].Name) 
                        { 
                            foreach (var product in categories[i].products)
                            {
                                int k = 0;
                                Console.Write($"{k + 1}.");
                                product.ShowInfo();
                            }
                            int choice_for_food;
                            choice_for_food = int.Parse(Console.ReadLine());
                            for (int k = 0; k < categories[i].products.Count(); k++)
                            {
                                if (categories[i].products[choice_for_food - 1] == categories[i].products[k])
                                {
                                    categories[i].products[k].ShowMoreInfo();
                                    Console.WriteLine("1.Buy");
                                    string choice_for_buy;
                                    choice_for_buy = Console.ReadLine();
                                    if (choice_for_buy == "1")
                                    {
                                        User.bucket.Add(categories[i].products[choice_for_food]);
                                        Console.WriteLine("1.Go to basket");
                                        string ch = Console.ReadLine();
                                        if(ch == "1")
                                        {
                                            User.bucket.ShowInfo();
                                            Console.WriteLine("1.Remove the product");
                                            string choice_remove = Console.ReadLine();
                                            if(choice_remove == "1")
                                            {
                                                Console.WriteLine("Choose the product to remove");
                                                User.bucket.ShowInfo();
                                                int cho = int.Parse(Console.ReadLine());
                                                for (int c = 0; c < User.bucket.products.Count(); c++)
                                                {
                                                    if(c == cho)
                                                    {
                                                        User.bucket.Delete(User.bucket.products[c]);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else throw new Exception("Wrong Choice");
                                }
                            }
                        }
                    }
                }

            }
            else if(choice == "2" ) 
            {
                userLoginService.CheckForRegister();
            }
            else
            {
                throw new Exception("Wrong choice");
            }
        }
    }
}
