using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class User
    {
        public string userID { get; set; }
        public string Name { get; set; }
        public string Password { get; private set; }
        public bool Admin { get; set; }

        public User (string user, string name, string password,bool admin)
        {
            userID = user;
            Name = name;
            Password = password;
            Admin = admin;
        }
    }
}
