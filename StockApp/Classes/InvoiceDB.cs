using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class InvoiceDB
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }

        public InvoiceDB(int id, string date, double amount)
        {
            ID = id;
            Date = date;
            Amount = amount;
        }
    }
}
