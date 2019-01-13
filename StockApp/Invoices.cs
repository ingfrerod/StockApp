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
            try
            {
                if (string.IsNullOrWhiteSpace(TxtID.Text.Trim()) == false)
                {
                    Engine.idcustomer = int.Parse(TxtID.Text);
                    Engine.SCustumer();
                    LblCustomerName.Text = Engine.NameCustomer;
                    LblCustomerAddress.Text = Engine.AddressCustomer;
                    TxtIDPro.Focus();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error : " + error);
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtIDPro.Text.Trim()) == false)
                {
                    Engine.idproduct = int.Parse(TxtIDPro.Text);
                    Engine.SProduct();
                    LblDescriptionProduct.Text = Engine.ProductDescription;
                    LblPriceProd.Text = Convert.ToString(Engine.ProductPrice);
                    lblStock.Text = Convert.ToString(Engine.productStock);
                    TxtQty.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error : " + error);
            }

        }
        public static int counter_row = 0;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtQty.Text) <= int.Parse(lblStock.Text))
            {
                bool addedbefore = false;
                int num_row = 0;

                if (counter_row == 0)
                {
                    dataGridView1.Rows.Add(TxtIDPro.Text, LblDescriptionProduct.Text, LblPriceProd.Text, TxtQty.Text);
                    double totalprice = Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[3].Value);
                    dataGridView1.Rows[counter_row].Cells[4].Value = totalprice;
                    counter_row++;

                }
                else
                {
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (r.Cells[0].Value.ToString()==TxtIDPro.Text)
                        {
                            addedbefore = true;
                            num_row = r.Index;
                        }
                    }
                    if (addedbefore==true)
                    {
                        dataGridView1.Rows[num_row].Cells[3].Value = (Convert.ToDouble(TxtQty.Text) + Convert.ToDouble(dataGridView1.Rows[num_row].Cells[3].Value)).ToString();
                        double totalprice = Convert.ToDouble(dataGridView1.Rows[num_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_row].Cells[3].Value);
                        dataGridView1.Rows[num_row].Cells[4].Value = totalprice;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(TxtIDPro.Text, LblDescriptionProduct.Text, LblPriceProd.Text, TxtQty.Text);
                        double totalprice = Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[3].Value);
                        dataGridView1.Rows[counter_row].Cells[4].Value = totalprice;
                        counter_row++;

                    }
                }
                
            }

        }
    }
}
