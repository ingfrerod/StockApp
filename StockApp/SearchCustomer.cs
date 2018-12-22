using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class SearchCustomer : Search
    {
        public SearchCustomer()
        {
            InitializeComponent();
           
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.CustomerList;
        }
    }
}
