namespace EczaneDepoDB.Modules.Prescription
{
    partial class Receipt
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
            this.Total_Due = new System.Windows.Forms.Label();
            this.LBL_AmountPayable = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_NationalId = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total_Due
            // 
            this.Total_Due.AutoSize = true;
            this.Total_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Total_Due.Location = new System.Drawing.Point(156, 334);
            this.Total_Due.Name = "Total_Due";
            this.Total_Due.Size = new System.Drawing.Size(119, 20);
            this.Total_Due.TabIndex = 19;
            this.Total_Due.Text = "Toplam Tutar:";
            // 
            // LBL_AmountPayable
            // 
            this.LBL_AmountPayable.AutoSize = true;
            this.LBL_AmountPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_AmountPayable.Location = new System.Drawing.Point(180, 334);
            this.LBL_AmountPayable.Name = "LBL_AmountPayable";
            this.LBL_AmountPayable.Size = new System.Drawing.Size(0, 20);
            this.LBL_AmountPayable.TabIndex = 18;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Price.Location = new System.Drawing.Point(156, 267);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(53, 20);
            this.lbl_Price.TabIndex = 17;
            this.lbl_Price.Text = "Fiyat:";
            // 
            // lbl_NationalId
            // 
            this.lbl_NationalId.AutoSize = true;
            this.lbl_NationalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_NationalId.Location = new System.Drawing.Point(145, 42);
            this.lbl_NationalId.Name = "lbl_NationalId";
            this.lbl_NationalId.Size = new System.Drawing.Size(87, 20);
            this.lbl_NationalId.TabIndex = 16;
            this.lbl_NationalId.Text = "TC Kimlik:";
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Buy.Location = new System.Drawing.Point(294, 379);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(246, 35);
            this.btn_Buy.TabIndex = 15;
            this.btn_Buy.Text = "Öde";
            this.btn_Buy.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(294, 334);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total_Due);
            this.Controls.Add(this.LBL_AmountPayable);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_NationalId);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total_Due;
        private System.Windows.Forms.Label LBL_AmountPayable;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_NationalId;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}