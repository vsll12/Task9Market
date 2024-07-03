using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

       public Bucket bucket;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
