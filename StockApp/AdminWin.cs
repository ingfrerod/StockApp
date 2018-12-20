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
    public partial class AdminWin : Form
    {
        public AdminWin()
        {
            InitializeComponent();
        }

        private void AdminWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminWin_Load(object sender, EventArgs e)
        {   
            foreach (var c in DataBase.UserList)
            {
                if (c.userID == Login.IdSave)
                {
                    AdminName.Text = c.Name;
                    AdminUser.Text = c.userID;
                }
            }
        }
    }
}
