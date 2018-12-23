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
    public partial class Login : WinBase
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string IdSave = "";
        public static string TxtSaveID = "";
        public static string TxtSavePsw = "";
        public static int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            TxtSaveID = txtID.Text.Trim();
            TxtSavePsw = txtPsw.Text.Trim();
            count = 0;

            Engine.LoginWin();

            if (count == 0)
            {
                MessageBox.Show("Your ID or Password are wrong, please try again");
                txtID.Text = "";
                txtPsw.Text = "";
                txtID.Focus();
            }
            else
            {
                this.Hide();
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
