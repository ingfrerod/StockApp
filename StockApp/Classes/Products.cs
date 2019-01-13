using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Products
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Products (int id, string description, double price, int stock)
        {
            ID = id;
            Description = description;
            Price = price;
            Stock = stock;

        }
    }
}
