﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }
    }
}
