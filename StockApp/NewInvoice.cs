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
    public partial class NewInvoice : WinBase
    {
        

        public NewInvoice()
        {
            InitializeComponent();
        }



        private void NewInvoice_Load(object sender, EventArgs e)
        {
            LblUser.Text = Login.IDUser;
            LblDate.Text = DateTime.Now.ToString("M/d/yyyy");
            dataGridView1.DataSource = DataBase.InvoiceList;
            double Total = 0;
            foreach (var r in DataBase.InvoiceList)
            {
                Total = Total + r.Amount;
            }
            LblTotalInv.Text = Total.ToString();
        }
    }
}
