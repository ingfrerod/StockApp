using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class DataBase
    {

        public static List<User> UserList { get; set; } = new List<User>
        {
            new User("FR","Fredy Rodriguez","123",true),
            new User("AS","Andrea Suarez","223",false),
            new User("AA","Angie Antonova","456",false)

        };
       
        
        
        
        
        
       

      
    }
}
    