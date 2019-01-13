namespace StockApp
{
    partial class ProductManagement
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
            this.TxtIdPro = new System.Windows.Forms.TextBox();
            this.TxtDesPro = new System.Windows.Forms.TextBox();
            this.TxtPricePro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 49);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 99);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 156);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 215);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(410, 271);
            // 
            // TxtIdPro
            // 
            this.TxtIdPro.Location = new System.Drawing.Point(142, 66);
            this.TxtIdPro.Name = "TxtIdPro";
            this.TxtIdPro.Size = new System.Drawing.Size(141, 20);
            this.TxtIdPro.TabIndex = 5;
            // 
            // TxtDesPro
            // 
            this.TxtDesPro.Location = new System.Drawing.Point(142, 118);
            this.TxtDesPro.Name = "TxtDesPro";
            this.TxtDesPro.Size = new System.Drawing.Size(141, 20);
            this.TxtDesPro.TabIndex = 6;
            // 
            // TxtPricePro
            // 
            this.TxtPricePro.Location = new System.Drawing.Point(142, 175);
            this.TxtPricePro.Name = "TxtPricePro";
            this.TxtPricePro.Size = new System.Drawing.Size(141, 20);
            this.TxtPricePro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(142, 222);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(141, 20);
            this.TxtStock.TabIndex = 12;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 349);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPricePro);
            this.Controls.Add(this.TxtDesPro);
            this.Controls.Add(this.TxtIdPro);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.TxtIdPro, 0);
            this.Controls.SetChildIndex(this.TxtDesPro, 0);
            this.Controls.SetChildIndex(this.TxtPricePro, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtStock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdPro;
        private System.Windows.Forms.TextBox TxtDesPro;
        private System.Windows.Forms.TextBox TxtPricePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStock;
    }
}