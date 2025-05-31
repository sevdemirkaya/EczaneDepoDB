namespace EczaneDepoDB.Modules.DrugStock
{
    partial class AddDrug
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_DrugName = new System.Windows.Forms.Label();
            this.btn_AddDrug = new System.Windows.Forms.Button();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.txt_DrugName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quantity.Location = new System.Drawing.Point(376, 222);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(63, 20);
            this.lbl_quantity.TabIndex = 28;
            this.lbl_quantity.Text = "Miktar:";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Quantity.Location = new System.Drawing.Point(518, 222);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(200, 20);
            this.txt_Quantity.TabIndex = 27;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_desc.Location = new System.Drawing.Point(376, 182);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(105, 20);
            this.lbl_desc.TabIndex = 26;
            this.lbl_desc.Text = "Description:";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Description.Location = new System.Drawing.Point(518, 182);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 20);
            this.txt_Description.TabIndex = 25;
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Barcode.Location = new System.Drawing.Point(376, 146);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(71, 20);
            this.lbl_Barcode.TabIndex = 24;
            this.lbl_Barcode.Text = "Barkod:";
            // 
            // lbl_DrugName
            // 
            this.lbl_DrugName.AutoSize = true;
            this.lbl_DrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DrugName.Location = new System.Drawing.Point(376, 106);
            this.lbl_DrugName.Name = "lbl_DrugName";
            this.lbl_DrugName.Size = new System.Drawing.Size(74, 20);
            this.lbl_DrugName.TabIndex = 23;
            this.lbl_DrugName.Text = "İlaç Adı:";
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddDrug.Location = new System.Drawing.Point(518, 319);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(200, 30);
            this.btn_AddDrug.TabIndex = 21;
            this.btn_AddDrug.Text = "İlacı Ekle";
            this.btn_AddDrug.UseVisualStyleBackColor = false;
            this.btn_AddDrug.Click += new System.EventHandler(this.btn_AddDrug_Click);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Barcode.Location = new System.Drawing.Point(518, 146);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(200, 20);
            this.txt_Barcode.TabIndex = 20;
            // 
            // txt_DrugName
            // 
            this.txt_DrugName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DrugName.Location = new System.Drawing.Point(518, 106);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(376, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ücret";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Price.Location = new System.Drawing.Point(518, 261);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(200, 20);
            this.txt_Price.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(503, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "İlacı buradan ekleyebilirsiniz.";
            // 
            // AddDrug
            // 
            this.ClientSize = new System.Drawing.Size(1369, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.lbl_DrugName);
            this.Controls.Add(this.btn_AddDrug);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.txt_DrugName);
            this.Name = "AddDrug";
            this.Text = "Yeni İlaç Ekle";
            this.Load += new System.EventHandler(this.AddDrug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.Label lbl_DrugName;
        private System.Windows.Forms.Button btn_AddDrug;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.TextBox txt_DrugName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label2;
    }
}
