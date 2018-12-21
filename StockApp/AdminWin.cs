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
    public partial class AdminWin : WinBase
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalContainer principal = new PrincipalContainer();
            this.Hide();
            principal.Show();
        }
    }
}
