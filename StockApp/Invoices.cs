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
    public partial class Invoices : Process
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void LblUser_Click(object sender, EventArgs e)
        {
           
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            LblUser.Text = Login.IDUser;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text.Trim()) == false)
            {
                Engine.idcustomer = int.Parse(TxtID.Text);
                Engine.SCustumer();
                TxtCustomer.Text = Engine.NameCustomer;
                Txtadress.Text = Engine.AddressCustomer;
                TxtIDPro.Focus();
            }
        }
    }
}
