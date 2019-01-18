namespace StockApp
{
    partial class NewInvoice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTotalInv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(498, 372);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // LblTotalInv
            // 
            this.LblTotalInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalInv.Location = new System.Drawing.Point(358, 328);
            this.LblTotalInv.Name = "LblTotalInv";
            this.LblTotalInv.Size = new System.Drawing.Size(180, 23);
            this.LblTotalInv.TabIndex = 43;
            this.LblTotalInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total CZK";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Date";
            // 
            // LblDate
            // 
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDate.Location = new System.Drawing.Point(91, 63);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(196, 23);
            this.LblDate.TabIndex = 50;
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUser
            // 
            this.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUser.Location = new System.Drawing.Point(91, 24);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(196, 23);
            this.LblUser.TabIndex = 47;
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "User";
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotalInv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewInvoice";
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.LblTotalInv, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.LblUser, 0);
            this.Controls.SetChildIndex(this.LblDate, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblTotalInv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label1;
    }
}