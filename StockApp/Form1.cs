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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "NEW" && txtPsw.Text == "123")
            {
                MessageBox.Show("Welcome to the app NEW");
            }
            else
            {
                MessageBox.Show("Your ID or Password are wrong, please try again");
                txtID.Text = "";
                txtPsw.Text = "";
                txtID.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
