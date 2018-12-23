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
            dataGridView1.ClearSelection();
            String searchValue = textBox1.Text;  
            int rowIndex = -1;
            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[rowIndex].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        counter++;
                        break;
                    }
                    
                }
                
            }
            if (counter == 0)
            {
                    MessageBox.Show(textBox1.Text + " is not in our database");
            }

            /*if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;

                    
                    dataGridView1.DataSource = DataBase.CustomerList.Select(x => x.Name == textBox1.Text.Trim());
                    MessageBox.Show("Is here");
                }
                catch(Exception error)
                {
                    MessageBox.Show("Eror" + error);
                }
            }
            else
            {
                MessageBox.Show("Eror");
            }*/
        }
    }
}
