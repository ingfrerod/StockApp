﻿using System;
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
    public partial class SearchProduct : Search
    {
        public SearchProduct()
        {
            InitializeComponent();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.ProductsList;
        }
    }
}
