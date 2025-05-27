namespace EczaneDepoDB.Modules.DrugStock
{
    partial class EditDrug
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
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_DrugName = new System.Windows.Forms.Label();
            this.btn_AddDrug = new System.Windows.Forms.Button();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.txt_DrugName = new System.Windows.Forms.TextBox();
            this.txt_DrugId = new System.Windows.Forms.TextBox();
            this.lbl_DrugId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Location = new System.Drawing.Point(186, 171);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(44, 13);
            this.lbl_Barcode.TabIndex = 13;
            this.lbl_Barcode.Text = "Barkod:";
            // 
            // lbl_DrugName
            // 
            this.lbl_DrugName.AutoSize = true;
            this.lbl_DrugName.Location = new System.Drawing.Point(186, 131);
            this.lbl_DrugName.Name = "lbl_DrugName";
            this.lbl_DrugName.Size = new System.Drawing.Size(45, 13);
            this.lbl_DrugName.TabIndex = 12;
            this.lbl_DrugName.Text = "İlaç Adı:";
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.Location = new System.Drawing.Point(266, 208);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(200, 30);
            this.btn_AddDrug.TabIndex = 10;
            this.btn_AddDrug.Text = "İlacı Ekle";
            this.btn_AddDrug.UseVisualStyleBackColor = true;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(266, 168);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(200, 20);
            this.txt_Barcode.TabIndex = 9;
            // 
            // txt_DrugName
            // 
            this.txt_DrugName.Location = new System.Drawing.Point(266, 128);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugName.TabIndex = 8;
            // 
            // txt_DrugId
            // 
            this.txt_DrugId.Location = new System.Drawing.Point(266, 88);
            this.txt_DrugId.Name = "txt_DrugId";
            this.txt_DrugId.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugId.TabIndex = 7;
            // 
            // lbl_DrugId
            // 
            this.lbl_DrugId.AutoSize = true;
            this.lbl_DrugId.Location = new System.Drawing.Point(186, 91);
            this.lbl_DrugId.Name = "lbl_DrugId";
            this.lbl_DrugId.Size = new System.Drawing.Size(41, 13);
            this.lbl_DrugId.TabIndex = 11;
            this.lbl_DrugId.Text = "İlaç ID:";
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.lbl_DrugName);
            this.Controls.Add(this.lbl_DrugId);
            this.Controls.Add(this.btn_AddDrug);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.txt_DrugName);
            this.Controls.Add(this.txt_DrugId);
            this.Name = "EditDrug";
            this.Text = "EditDrug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.Label lbl_DrugName;
        private System.Windows.Forms.Button btn_AddDrug;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.TextBox txt_DrugName;
        private System.Windows.Forms.TextBox txt_DrugId;
        private System.Windows.Forms.Label lbl_DrugId;
    }
}