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
    public partial class ProductManagement : Management
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        public override Boolean Save()
        {  if (string.IsNullOrWhiteSpace(TxtIdPro.Text) || string.IsNullOrWhiteSpace(TxtDesPro.Text) || string.IsNullOrWhiteSpace(TxtPricePro.Text))
            {
                MessageBox.Show("All fields are mandatory", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                var item = DataBase.ProductsList.SingleOrDefault(x => x.ID == int.Parse(TxtIdPro.Text));
                if (item == null)
                {

                    try
                    {
                        DataBase.ProductsList.Add(new Products(int.Parse(TxtIdPro.Text), TxtDesPro.Text, double.Parse(TxtPricePro.Text), int.Parse(TxtStock.Text)));
                        MessageBox.Show(TxtDesPro.Text + " has been successfully saved ");
                        TxtIdPro.Text = "";
                        TxtDesPro.Text = "";
                        TxtPricePro.Text = "";
                        TxtIdPro.Focus();
                        return true;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error" + error);
                        TxtIdPro.Text = "";
                        TxtDesPro.Text = "";
                        TxtPricePro.Text = "";
                        TxtIdPro.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("A product with ID "+ TxtIdPro.Text + " is already in Our Data Base");
                    TxtIdPro.Text = "";
                    TxtDesPro.Text = "";
                    TxtPricePro.Text = "";
                    TxtIdPro.Focus();
                    return false;
                }
            }
        }
           

        public override void Delete()
        {
            try
            {
                var item = DataBase.ProductsList.SingleOrDefault(x => x.ID == int.Parse(TxtIdPro.Text));
                if (item != null)
                {
                    MessageBox.Show(TxtDesPro.Text + " Has been Successfully deleted");
                    DataBase.ProductsList.Remove(item);
                    TxtIdPro.Text = "";
                    TxtDesPro.Text = "";
                    TxtPricePro.Text = "";
                    TxtIdPro.Focus();
                }
                else
                {
                    MessageBox.Show(TxtDesPro.Text + " Is not in Our stock");
                    TxtIdPro.Text = "";
                    TxtDesPro.Text = "";
                    TxtPricePro.Text = "";
                    TxtIdPro.Focus();
                }
            }catch(Exception error)
            {
                MessageBox.Show("Error" + error);
                TxtIdPro.Text = "";
                TxtDesPro.Text = "";
                TxtPricePro.Text = "";
                TxtIdPro.Focus();
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

        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchProduct SearchPro = new SearchProduct();
            SearchPro.ShowDialog();
            if (SearchPro.DialogResult == DialogResult.OK)
            {
                TxtIdPro.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtDesPro.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TxtPricePro.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TxtStock.Text = SearchPro.dataGridView1.Rows[SearchPro.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
           
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIdPro.Text) || string.IsNullOrWhiteSpace(TxtDesPro.Text) || string.IsNullOrWhiteSpace(TxtPricePro.Text))
            {
                MessageBox.Show("All fields are mandatory", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    var item = DataBase.ProductsList.SingleOrDefault(x => x.ID == int.Parse(TxtIdPro.Text));
                    if (item != null)
                    {
                        MessageBox.Show(TxtDesPro.Text + " Has been Successfully Updated");
                        item.ID = int.Parse(TxtIdPro.Text);
                        item.Description = TxtDesPro.Text;
                        item.Price = double.Parse(TxtPricePro.Text);
                        item.Stock = int.Parse(TxtStock.Text);
                        TxtIdPro.Text = "";
                        TxtDesPro.Text = "";
                        TxtPricePro.Text = "";
                        TxtIdPro.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" You cannot Update or change the product ID");
                        TxtIdPro.Text = "";
                        TxtDesPro.Text = "";
                        TxtPricePro.Text = "";
                        TxtIdPro.Focus();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error);
                    TxtIdPro.Text = "";
                    TxtDesPro.Text = "";
                    TxtPricePro.Text = "";
                    TxtIdPro.Focus();
                }
            }

        }
    }
    
}
