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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                        dataGridView1.DataSource = DataBase.CustomerList.Select(x => x.Name == textBox1.Text.Trim());

                }
                catch(Exception error)
                {
                    MessageBox.Show("Eror" + error);
                }
            }
        }
    }
}
