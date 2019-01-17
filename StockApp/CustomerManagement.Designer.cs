namespace StockApp
{
    partial class CustomerManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdCli = new System.Windows.Forms.TextBox();
            this.TxtNaCli = new System.Windows.Forms.TextBox();
            this.TxtIDCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 26);
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.Text = "Search Customer";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 66);
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.Text = "Add New Customer";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 106);
            this.button3.Size = new System.Drawing.Size(134, 23);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 144);
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.Text = "Update";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(331, 187);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.BtnExit.Size = new System.Drawing.Size(134, 25);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtAdCli
            // 
            this.TxtAdCli.Location = new System.Drawing.Point(137, 175);
            this.TxtAdCli.Name = "TxtAdCli";
            this.TxtAdCli.Size = new System.Drawing.Size(141, 20);
            this.TxtAdCli.TabIndex = 13;
            this.TxtAdCli.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtNaCli
            // 
            this.TxtNaCli.Location = new System.Drawing.Point(137, 118);
            this.TxtNaCli.Name = "TxtNaCli";
            this.TxtNaCli.Size = new System.Drawing.Size(141, 20);
            this.TxtNaCli.TabIndex = 12;
            this.TxtNaCli.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtIDCli
            // 
            this.TxtIDCli.Location = new System.Drawing.Point(137, 66);
            this.TxtIDCli.Name = "TxtIDCli";
            this.TxtIDCli.Size = new System.Drawing.Size(141, 20);
            this.TxtIDCli.TabIndex = 11;
            this.TxtIDCli.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAdCli);
            this.Controls.Add(this.TxtNaCli);
            this.Controls.Add(this.TxtIDCli);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.TxtIDCli, 0);
            this.Controls.SetChildIndex(this.TxtNaCli, 0);
            this.Controls.SetChildIndex(this.TxtAdCli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAdCli;
        private System.Windows.Forms.TextBox TxtNaCli;
        private System.Windows.Forms.TextBox TxtIDCli;
    }
}