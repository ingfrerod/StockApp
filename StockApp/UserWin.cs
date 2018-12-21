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
    public partial class UserWin : WinBase
    {
        public UserWin()
        {
            InitializeComponent();
        }

        private void UserWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserWin_Load(object sender, EventArgs e)
        {
            foreach (var c in DataBase.UserList)
            {
                if (c.userID == Login.IdSave)
                {
                    UserName.Text = c.Name;
                    UserUser.Text = c.userID;
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
