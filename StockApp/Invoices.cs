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
            Engine.InvoiceNumber();
            LblInvoiceN.Text= Engine.InvoiceNo.ToString();

            LblDate.Text = DateTime.Now.ToString("M/d/yyyy");
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
                           Engine.Qupdate = int.Parse(TxtQty.Text);
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
                    Engine.Qtyupdater();
                    lblStock.Text = Convert.ToString(Engine.Qupdate);


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
                        Engine.Qtyupdater();
                        lblStock.Text = Convert.ToString(Engine.Qupdate);

                    }
                    else
                    {
                        dataGridView1.Rows.Add(TxtIDPro.Text, LblDescriptionProduct.Text, LblPriceProd.Text, TxtQty.Text);
                        double totalprice = Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[3].Value);
                        dataGridView1.Rows[counter_row].Cells[4].Value = totalprice;
                        counter_row++;
                        Engine.Qtyupdater();
                        lblStock.Text = Convert.ToString(Engine.Qupdate);

                    }
                }
                TotalInvoice = 0;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    TotalInvoice += Convert.ToDouble(r.Cells[4].Value);
                }
                LblTotalInv.Text = "CZK " + TotalInvoice.ToString();
                }

            }

        }
        public static int counter_row = 0;
        public static double TotalInvoice;
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Engine.Qupdate = int.Parse(TxtQty.Text);
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
                        Engine.Qtyupdater();
                        lblStock.Text = Convert.ToString(Engine.Qupdate);


                    }
                    else
                    {
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if (r.Cells[0].Value.ToString() == TxtIDPro.Text)
                            {
                                addedbefore = true;
                                num_row = r.Index;
                            }
                        }
                        if (addedbefore == true)
                        {
                            dataGridView1.Rows[num_row].Cells[3].Value = (Convert.ToDouble(TxtQty.Text) + Convert.ToDouble(dataGridView1.Rows[num_row].Cells[3].Value)).ToString();
                            double totalprice = Convert.ToDouble(dataGridView1.Rows[num_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_row].Cells[3].Value);
                            dataGridView1.Rows[num_row].Cells[4].Value = totalprice;
                            Engine.Qtyupdater();
                            lblStock.Text = Convert.ToString(Engine.Qupdate);

                        }
                        else
                        {
                            dataGridView1.Rows.Add(TxtIDPro.Text, LblDescriptionProduct.Text, LblPriceProd.Text, TxtQty.Text);
                            double totalprice = Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[counter_row].Cells[3].Value);
                            dataGridView1.Rows[counter_row].Cells[4].Value = totalprice;
                            counter_row++;
                            Engine.Qtyupdater();
                            lblStock.Text = Convert.ToString(Engine.Qupdate);

                        }
                    }
                    TotalInvoice = 0;
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        TotalInvoice += Convert.ToDouble(r.Cells[4].Value);
                    }
                    LblTotalInv.Text =TotalInvoice.ToString();
                }
                else
                {   if (int.Parse(lblStock.Text) == 0)
                    {
                        MessageBox.Show(" Out of Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Only " + lblStock.Text + " in Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
            

            }
            catch(Exception error)
            {
                MessageBox.Show("Error : " + error);
            }
        


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (counter_row > 0)
            {
                TotalInvoice = TotalInvoice - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                LblTotalInv.Text = TotalInvoice.ToString();
                Engine.idproduct = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                Engine.Qupdate = -(Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value));
                Engine.Qtyupdater();
                lblStock.Text = LblIdProduct.Text = LblPriceProd.Text= TxtQty.Text = "";
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                counter_row--;
            }
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomer SearchCus = new SearchCustomer();
            SearchCus.ShowDialog();
            if (SearchCus.DialogResult == DialogResult.OK)
            {
                TxtID.Text = SearchCus.dataGridView1.Rows[SearchCus.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                LblCustomerName.Text= SearchCus.dataGridView1.Rows[SearchCus.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                LblCustomerAddress.Text= SearchCus.dataGridView1.Rows[SearchCus.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TxtIDPro.Focus();
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            SearchProduct SearchPro = new SearchProduct();
            SearchPro.ShowDialog();
            if (SearchPro.DialogResult == DialogResult.OK)
            {
                TxtIDPro.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                LblDescriptionProduct.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                LblPriceProd.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                lblStock.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                Engine.idproduct = int.Parse(TxtIDPro.Text);
                TxtQty.Focus();

            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    TotalInvoice = TotalInvoice - (Convert.ToDouble(dataGridView1.Rows[r.Index].Cells[4].Value));
                    LblTotalInv.Text = TotalInvoice.ToString();
                    Engine.idproduct = Convert.ToInt16(dataGridView1.Rows[r.Index].Cells[0].Value);
                    Engine.Qupdate = -(Convert.ToInt16(dataGridView1.Rows[r.Index].Cells[3].Value));
                    Engine.Qtyupdater();
                lblStock.Text = LblPriceProd.Text = TxtQty.Text = TxtID.Text =
            LblCustomerName.Text  = LblCustomerAddress.Text = LblDescriptionProduct.Text = "";

                counter_row--;
                }
            dataGridView1.Rows.Clear();
            
            
        }
        
        private void BtnInvoice_Click(object sender, EventArgs e)
        {

            DataBase.InvoiceList.Add(new InvoiceDB(int.Parse(LblInvoiceN.Text),LblDate.Text.ToString(),double.Parse(LblTotalInv.Text)));
            MessageBox.Show("Invoice Created");
            lblStock.Text = LblPriceProd.Text = TxtQty.Text = TxtID.Text= 
                LblCustomerName.Text = LblCustomerAddress.Text= LblDescriptionProduct.Text= "";
            Engine.InvoiceNumber();
            LblInvoiceN.Text = Engine.InvoiceNo.ToString();
            dataGridView1.Rows.Clear();
        }
    }
}
