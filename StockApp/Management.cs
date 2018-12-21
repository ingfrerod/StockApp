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
    public partial class Management : WinBase
    {
        public Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New();
        }
    }
}
