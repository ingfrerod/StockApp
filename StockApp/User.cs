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
        public string Password { get; private set; }
        public bool Admin { get; set; }

        public User (string user, string password,bool admin)
        {
            userID = user;
            Password = password;
            Admin = admin;
        }
    }
}
