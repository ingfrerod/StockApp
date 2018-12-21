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

        public Products (int id, string description, double price)
        {
            ID = id;
            Description = description;
            Price = price;

        }
    }
}
