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

        public static List<Products> ProductsList { get; set; } = new List<Products>
        {
            new Products(123, "Rice x 1 kg", 45.3, 30),
            new Products(456, "Milk x 1000 ml", 78.3, 40)
        };

        public static List<Customer> CustomerList { get; set; } = new List<Customer>
        {
            new Customer(123,"Juan Rodriguez", "Prague"),
            new Customer(785,"Daniel Perez", "Prague"),
            new Customer(785,"Daniel Saenz", "Prague")
        };
        
       
        
        
        
        
        
       

      
    }
}
    