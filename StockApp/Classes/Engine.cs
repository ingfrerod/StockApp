using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Engine
    {
        public static int idcustomer;
        public static string NameCustomer;
        public static string AddressCustomer;
        public static int idproduct;
        public static string ProductDescription;
        public static double ProductPrice;
        public static int productStock;
        public static int Qupdate;
        public static int InvoiceNo=10000;


        public static void LoginWin()
        {   

            foreach (var c in DataBase.UserList)
            {
                if (Login.TxtSaveID == c.userID && Login.TxtSavePsw == c.Password)
                {
                    if (c.Admin)
                    {
                        AdminWin adminWin = new AdminWin();
                       
                        Login.IdSave = c.userID;
                        Login.IDUser = c.Name;
                        adminWin.Show();
                        Login.count++;

       
                    }
                    else
                    {
                        UserWin userWin = new UserWin();
                         Login.IdSave = c.userID;
                        userWin.Show();
                        Login.count++;

                    }

                }
            }
        }
        public static void SCustumer()
        {
            foreach (var c in DataBase.CustomerList)
            {
                if (c.ID == idcustomer)
                {
                    NameCustomer = c.Name;
                    AddressCustomer = c.Address;
                   
                }
            }
        }
        public static void SProduct()
        {
            foreach (var c in DataBase.ProductsList)
            {
                if (c.ID == idproduct)
                {
                    ProductDescription = c.Description;
                    ProductPrice = c.Price;
                    productStock = c.Stock;
                }
            }
        }
        public static void Qtyupdater()
        {
            foreach (var c in DataBase.ProductsList)
            {
                if (c.ID==idproduct)
                {
                    c.Stock = c.Stock - Qupdate;
                    Qupdate = c.Stock;
                    

                }
            }
        }
        public static void InvoiceNumber()
        {
            InvoiceNo++;
           
        }
    }
}
