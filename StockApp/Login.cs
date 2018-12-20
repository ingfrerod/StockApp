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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var c in DataBase.UserList)
            {
            
            if (txtID.Text == c.userID && txtPsw.Text == c.Password )
            {
                    if (c.Admin)
                    {
                        AdminWin adminWin = new AdminWin();
                        this.Hide();
                        adminWin.Show();
                        count++;
                    }
                    else
                    {
                        UserWin userWin = new UserWin();
                        this.Hide();
                        userWin.Show();
                        count++;
                    }
                
                
            }
            
            }
            if (count == 0)
            {
                MessageBox.Show("Your ID or Password are wrong, please try again");
                txtID.Text = "";
                txtPsw.Text = "";
                txtID.Focus();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
