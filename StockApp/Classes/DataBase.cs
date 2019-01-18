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
            new Products(123, "Ipad 2018", 17000, 30),
            new Products(456, "Iphone X", 25000, 40),
            new Products(678, "Samsung s9+", 16000, 50),
            new Products(891, "MacBook Pro", 54000, 4),
            new Products(457, "Laptop Lenovo A123 ", 20000, 0),
            new Products(679, "Samsung M3", 11000, 150),
            new Products(898, "Huawei Mate pro", 25000, 14)
        };

        public static List<Customer> CustomerList { get; set; } = new List<Customer>
        {
            new Customer(123,"Juan Rodriguez", "Prague"),
            new Customer(456,"Daniel Perez", "Prague"),
            new Customer(789,"Daniel Saenz", "Prague")
        };

        public static List<InvoiceDB> InvoiceList { get; set; } = new List<InvoiceDB>
        {
            new InvoiceDB(10000,"18 - 01 - 2019",78526)

        };









    }
}
    