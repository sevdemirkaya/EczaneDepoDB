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
            this.txt_DrugName = new System.Windows.Forms.TextBox();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.btn_AddDrug = new System.Windows.Forms.Button();
            this.lbl_DrugName = new System.Windows.Forms.Label();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DrugName
            // 
            this.txt_DrugName.Location = new System.Drawing.Point(120, 70);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugName.TabIndex = 1;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(120, 110);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(200, 20);
            this.txt_Barcode.TabIndex = 2;
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.Location = new System.Drawing.Point(120, 150);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(200, 30);
            this.btn_AddDrug.TabIndex = 3;
            this.btn_AddDrug.Text = "İlacı Ekle";
            this.btn_AddDrug.UseVisualStyleBackColor = true;
            this.btn_AddDrug.Click += new System.EventHandler(this.btn_AddDrug_Click);
            // 
            // lbl_DrugName
            // 
            this.lbl_DrugName.AutoSize = true;
            this.lbl_DrugName.Location = new System.Drawing.Point(40, 73);
            this.lbl_DrugName.Name = "lbl_DrugName";
            this.lbl_DrugName.Size = new System.Drawing.Size(45, 13);
            this.lbl_DrugName.TabIndex = 5;
            this.lbl_DrugName.Text = "İlaç Adı:";
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Location = new System.Drawing.Point(40, 113);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(44, 13);
            this.lbl_Barcode.TabIndex = 6;
            this.lbl_Barcode.Text = "Barkod:";
            // 
            // AddDrug
            // 
            this.ClientSize = new System.Drawing.Size(1369, 493);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.lbl_DrugName);
            this.Controls.Add(this.btn_AddDrug);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.txt_DrugName);
            this.Name = "AddDrug";
            this.Text = "Yeni İlaç Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_DrugName;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.Button btn_AddDrug;
        private System.Windows.Forms.Label lbl_DrugName;
        private System.Windows.Forms.Label lbl_Barcode;
    }
}
