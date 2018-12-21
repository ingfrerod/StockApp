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
        {
            try
            {
                DataBase.ProductsList.Add(new Products(int.Parse(TxtIdPro.Text), TxtDesPro.Text, double.Parse(TxtPricePro.Text)));
                MessageBox.Show(TxtIdPro.Text + " has been successfully saved ");
                return true;
            }
            catch(Exception error)
            {
                MessageBox.Show("Error" + error);
                return false;
            }
        }

        public override void Delete()
        {
            var item = DataBase.ProductsList.SingleOrDefault(x => x.ID == int.Parse(TxtIdPro.Text));
            if (item != null)
            {
                MessageBox.Show(TxtDesPro.Text + " Has been Successfully deleted");
                DataBase.ProductsList.Remove(item);
            }
            else
            {
                MessageBox.Show(TxtDesPro.Text + " Is not in Our stock");
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
    }
    
}
