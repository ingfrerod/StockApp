namespace StockApp
{
    partial class Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtIDPro = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchCus = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblCustomerAddress = new System.Windows.Forms.Label();
            this.LblIdProduct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl20 = new System.Windows.Forms.Label();
            this.Lbl21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblDescriptionProduct = new System.Windows.Forms.Label();
            this.LblPriceProd = new System.Windows.Forms.Label();
            this.SearchProd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.LblTotalInv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(594, 439);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(1);
            this.BtnExit.Size = new System.Drawing.Size(75, 21);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(594, 192);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(594, 233);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.Location = new System.Drawing.Point(594, 274);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnCustomer.TabIndex = 3;
            this.BtnCustomer.Text = "Customers";
            this.BtnCustomer.UseVisualStyleBackColor = true;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Location = new System.Drawing.Point(594, 315);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(75, 23);
            this.BtnProducts.TabIndex = 4;
            this.BtnProducts.Text = "Products";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(594, 354);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnInvoice
            // 
            this.BtnInvoice.Location = new System.Drawing.Point(594, 396);
            this.BtnInvoice.Name = "BtnInvoice";
            this.BtnInvoice.Size = new System.Drawing.Size(75, 23);
            this.BtnInvoice.TabIndex = 6;
            this.BtnInvoice.Text = "Invoice";
            this.BtnInvoice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(87, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(138, 20);
            this.TxtID.TabIndex = 15;
            // 
            // TxtIDPro
            // 
            this.TxtIDPro.Location = new System.Drawing.Point(87, 178);
            this.TxtIDPro.Name = "TxtIDPro";
            this.TxtIDPro.Size = new System.Drawing.Size(138, 20);
            this.TxtIDPro.TabIndex = 18;
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(413, 210);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(100, 20);
            this.TxtQty.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProductDes,
            this.ProdPrice,
            this.ProductQ,
            this.TotalPrice});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(27, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 178);
            this.dataGridView1.TabIndex = 23;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ID ";
            this.ProdID.Name = "ProdID";
            this.ProdID.Width = 80;
            // 
            // ProductDes
            // 
            this.ProductDes.HeaderText = "Description";
            this.ProductDes.Name = "ProductDes";
            this.ProductDes.Width = 150;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProductQ
            // 
            this.ProductQ.HeaderText = "Quantity";
            this.ProductQ.Name = "ProductQ";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(324, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 88);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // SearchCus
            // 
            this.SearchCus.Location = new System.Drawing.Point(231, 45);
            this.SearchCus.Name = "SearchCus";
            this.SearchCus.Size = new System.Drawing.Size(52, 23);
            this.SearchCus.TabIndex = 25;
            this.SearchCus.Text = "Search";
            this.SearchCus.UseVisualStyleBackColor = true;
            this.SearchCus.Click += new System.EventHandler(this.button7_Click);
            // 
            // LblUser
            // 
            this.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUser.Location = new System.Drawing.Point(497, 1);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(196, 23);
            this.LblUser.TabIndex = 26;
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCustomerName.Location = new System.Drawing.Point(87, 73);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(196, 23);
            this.LblCustomerName.TabIndex = 28;
            this.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCustomerAddress
            // 
            this.LblCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCustomerAddress.Location = new System.Drawing.Point(87, 104);
            this.LblCustomerAddress.Name = "LblCustomerAddress";
            this.LblCustomerAddress.Size = new System.Drawing.Size(196, 23);
            this.LblCustomerAddress.TabIndex = 29;
            this.LblCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCustomerAddress.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblIdProduct
            // 
            this.LblIdProduct.AutoSize = true;
            this.LblIdProduct.Location = new System.Drawing.Point(13, 181);
            this.LblIdProduct.Name = "LblIdProduct";
            this.LblIdProduct.Size = new System.Drawing.Size(18, 13);
            this.LblIdProduct.TabIndex = 30;
            this.LblIdProduct.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Product ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Lbl20
            // 
            this.Lbl20.AutoSize = true;
            this.Lbl20.Location = new System.Drawing.Point(13, 213);
            this.Lbl20.Name = "Lbl20";
            this.Lbl20.Size = new System.Drawing.Size(60, 13);
            this.Lbl20.TabIndex = 33;
            this.Lbl20.Text = "Description";
            // 
            // Lbl21
            // 
            this.Lbl21.AutoSize = true;
            this.Lbl21.Location = new System.Drawing.Point(13, 243);
            this.Lbl21.Name = "Lbl21";
            this.Lbl21.Size = new System.Drawing.Size(31, 13);
            this.Lbl21.TabIndex = 34;
            this.Lbl21.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Quantity";
            // 
            // LblDescriptionProduct
            // 
            this.LblDescriptionProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDescriptionProduct.Location = new System.Drawing.Point(87, 208);
            this.LblDescriptionProduct.Name = "LblDescriptionProduct";
            this.LblDescriptionProduct.Size = new System.Drawing.Size(204, 23);
            this.LblDescriptionProduct.TabIndex = 36;
            this.LblDescriptionProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPriceProd
            // 
            this.LblPriceProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPriceProd.Location = new System.Drawing.Point(87, 238);
            this.LblPriceProd.Name = "LblPriceProd";
            this.LblPriceProd.Size = new System.Drawing.Size(204, 23);
            this.LblPriceProd.TabIndex = 37;
            this.LblPriceProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchProd
            // 
            this.SearchProd.Location = new System.Drawing.Point(231, 178);
            this.SearchProd.Name = "SearchProd";
            this.SearchProd.Size = new System.Drawing.Size(52, 23);
            this.SearchProd.TabIndex = 38;
            this.SearchProd.Text = "Search";
            this.SearchProd.UseVisualStyleBackColor = true;
            this.SearchProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Stock";
            // 
            // lblStock
            // 
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStock.Location = new System.Drawing.Point(413, 181);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 23);
            this.lblStock.TabIndex = 40;
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalInv
            // 
            this.LblTotalInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalInv.Location = new System.Drawing.Point(432, 472);
            this.LblTotalInv.Name = "LblTotalInv";
            this.LblTotalInv.Size = new System.Drawing.Size(118, 23);
            this.LblTotalInv.TabIndex = 41;
            this.LblTotalInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 506);
            this.Controls.Add(this.LblTotalInv);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchProd);
            this.Controls.Add(this.LblPriceProd);
            this.Controls.Add(this.LblDescriptionProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbl21);
            this.Controls.Add(this.Lbl20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblIdProduct);
            this.Controls.Add(this.LblCustomerAddress);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.SearchCus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtIDPro);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInvoice);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.BtnDelete, 0);
            this.Controls.SetChildIndex(this.BtnCustomer, 0);
            this.Controls.SetChildIndex(this.BtnProducts, 0);
            this.Controls.SetChildIndex(this.BtnNew, 0);
            this.Controls.SetChildIndex(this.BtnInvoice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.TxtIDPro, 0);
            this.Controls.SetChildIndex(this.TxtQty, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.SearchCus, 0);
            this.Controls.SetChildIndex(this.LblUser, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.LblCustomerName, 0);
            this.Controls.SetChildIndex(this.LblCustomerAddress, 0);
            this.Controls.SetChildIndex(this.LblIdProduct, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Lbl20, 0);
            this.Controls.SetChildIndex(this.Lbl21, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.LblDescriptionProduct, 0);
            this.Controls.SetChildIndex(this.LblPriceProd, 0);
            this.Controls.SetChildIndex(this.SearchProd, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblStock, 0);
            this.Controls.SetChildIndex(this.LblTotalInv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtIDPro;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchCus;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblCustomerAddress;
        private System.Windows.Forms.Label LblIdProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl20;
        private System.Windows.Forms.Label Lbl21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblDescriptionProduct;
        private System.Windows.Forms.Label LblPriceProd;
        private System.Windows.Forms.Button SearchProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label LblTotalInv;
    }
}