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
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_NationalId = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.dg_DrugList = new System.Windows.Forms.DataGridView();
            this.txt_NationalId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugList)).BeginInit();
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
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Phone.Location = new System.Drawing.Point(156, 267);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(74, 20);
            this.lbl_Phone.TabIndex = 17;
            this.lbl_Phone.Text = "Telefon:";
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
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Location = new System.Drawing.Point(294, 334);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(240, 20);
            this.txt_TotalPrice.TabIndex = 14;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(294, 267);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(240, 20);
            this.txt_Phone.TabIndex = 13;
            this.txt_Phone.TextChanged += new System.EventHandler(this.integerOnlyTextChanged);
            // 
            // dg_DrugList
            // 
            this.dg_DrugList.AllowUserToAddRows = false;
            this.dg_DrugList.AllowUserToDeleteRows = false;
            this.dg_DrugList.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dg_DrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DrugList.Location = new System.Drawing.Point(149, 89);
            this.dg_DrugList.Name = "dg_DrugList";
            this.dg_DrugList.ReadOnly = true;
            this.dg_DrugList.Size = new System.Drawing.Size(473, 150);
            this.dg_DrugList.TabIndex = 12;
            // 
            // txt_NationalId
            // 
            this.txt_NationalId.Location = new System.Drawing.Point(290, 42);
            this.txt_NationalId.Name = "txt_NationalId";
            this.txt_NationalId.ReadOnly = true;
            this.txt_NationalId.Size = new System.Drawing.Size(244, 20);
            this.txt_NationalId.TabIndex = 11;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total_Due);
            this.Controls.Add(this.LBL_AmountPayable);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_NationalId);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.txt_TotalPrice);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.dg_DrugList);
            this.Controls.Add(this.txt_NationalId);
            this.Name = "Receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total_Due;
        private System.Windows.Forms.Label LBL_AmountPayable;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_NationalId;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.DataGridView dg_DrugList;
        private System.Windows.Forms.TextBox txt_NationalId;
    }
}