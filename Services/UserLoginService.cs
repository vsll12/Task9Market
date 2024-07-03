using Market.Models;

namespace Market.Services
{
    internal  class UserLoginService
    {
        User? User;
        List<User> users = new List<User>();

        public User? CheckForLogin()
        {
            Console.Clear();
            string name;
            Console.Write("Name : ");
            name = Console.ReadLine();
            string password;
            Console.Write("Password : ");
            password = Console.ReadLine();
            foreach (var user in users)
            {
                if(user.Username == name)
                {
                    if (user.Password == password)
                    {
                        User = user;
                        return User;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public void CheckForRegister()
        {
            Console.Clear();
            string name;
            Console.Write("Name : ");
            name = Console.ReadLine();
            string password;
            Console.Write("Password : ");
            password = Console.ReadLine();
            User user = new User(name,password);
            users.Add(user);
            Console.WriteLine("Welcome");
        }
    }
}
