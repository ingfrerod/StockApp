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
    public partial class CustomerManagement : Management
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        public override Boolean Save()
        {
            if (string.IsNullOrWhiteSpace(TxtIDCli.Text) || string.IsNullOrWhiteSpace(TxtNaCli.Text) || string.IsNullOrWhiteSpace(TxtAdCli.Text))
            {
                MessageBox.Show("All fields are mandatory", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                try
                {
                    DataBase.CustomerList.Add(new Customer(int.Parse(TxtIDCli.Text), TxtNaCli.Text, TxtAdCli.Text));
                    MessageBox.Show(TxtNaCli.Text + " has been successfully saved ");
                    TxtIDCli.Text = "";
                    TxtNaCli.Text = "";
                    TxtAdCli.Text = "";
                    TxtIDCli.Focus();
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error);
                    TxtIDCli.Text = "";
                    TxtNaCli.Text = "";
                    TxtAdCli.Text = "";
                    TxtIDCli.Focus();
                    return false;
                }
            }
            
        }

        public override void Delete()
        {
            try
            {
                var item = DataBase.CustomerList.SingleOrDefault(x => x.ID == int.Parse(TxtIDCli.Text));
                if (item != null)
                {
                    MessageBox.Show(TxtNaCli.Text + " Has been Successfully deleted");
                    DataBase.CustomerList.Remove(item);
                    TxtIDCli.Text = "";
                    TxtNaCli.Text = "";
                    TxtAdCli.Text = "";
                    TxtIDCli.Focus();
                }
                else
                {
                    MessageBox.Show(TxtNaCli.Text + " Is not in Our Database");
                    TxtIDCli.Text = "";
                    TxtNaCli.Text = "";
                    TxtAdCli.Text = "";
                    TxtIDCli.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
                TxtIDCli.Text = "";
                TxtNaCli.Text = "";
                TxtAdCli.Text = "";
                TxtIDCli.Focus();
            }


            //DataBase.ProductsList.RemoveAll(x => x.ID == int.Parse(TxtIdPro.Text));
            /*foreach (var c in DataBase.ProductsList)
            {
                if (c.ID == int.Parse(TxtIdPro.Text))
                {
                    MessageBox.Show(TxtDesPro.Text + " Has been Successfully deleted");
                    DataBase.ProductsList.Remove(c);
                    
                }
                else
                {
                    MessageBox.Show(TxtDesPro.Text + " Is not in Our stock");
                }
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
