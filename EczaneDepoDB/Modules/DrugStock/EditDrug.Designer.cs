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
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Barcode.Location = new System.Drawing.Point(141, 168);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(71, 20);
            this.lbl_Barcode.TabIndex = 13;
            this.lbl_Barcode.Text = "Barkod:";
            // 
            // lbl_DrugName
            // 
            this.lbl_DrugName.AutoSize = true;
            this.lbl_DrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DrugName.Location = new System.Drawing.Point(141, 128);
            this.lbl_DrugName.Name = "lbl_DrugName";
            this.lbl_DrugName.Size = new System.Drawing.Size(74, 20);
            this.lbl_DrugName.TabIndex = 12;
            this.lbl_DrugName.Text = "İlaç Adı:";
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddDrug.Location = new System.Drawing.Point(263, 346);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(200, 30);
            this.btn_AddDrug.TabIndex = 10;
            this.btn_AddDrug.Text = "İlacı Ekle";
            this.btn_AddDrug.UseVisualStyleBackColor = false;
            this.btn_AddDrug.Click += new System.EventHandler(this.btn_AddDrug_Click);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Barcode.Location = new System.Drawing.Point(266, 168);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(200, 20);
            this.txt_Barcode.TabIndex = 9;
            // 
            // txt_DrugName
            // 
            this.txt_DrugName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DrugName.Location = new System.Drawing.Point(266, 128);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugName.TabIndex = 8;
            // 
            // txt_DrugId
            // 
            this.txt_DrugId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DrugId.Location = new System.Drawing.Point(266, 88);
            this.txt_DrugId.Name = "txt_DrugId";
            this.txt_DrugId.ReadOnly = true;
            this.txt_DrugId.Size = new System.Drawing.Size(200, 20);
            this.txt_DrugId.TabIndex = 7;
            // 
            // lbl_DrugId
            // 
            this.lbl_DrugId.AutoSize = true;
            this.lbl_DrugId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DrugId.Location = new System.Drawing.Point(141, 88);
            this.lbl_DrugId.Name = "lbl_DrugId";
            this.lbl_DrugId.Size = new System.Drawing.Size(67, 20);
            this.lbl_DrugId.TabIndex = 11;
            this.lbl_DrugId.Text = "İlaç ID:";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_desc.Location = new System.Drawing.Point(141, 204);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(81, 20);
            this.lbl_desc.TabIndex = 15;
            this.lbl_desc.Text = "Açıklama";
            // 
            // txt_Description
            // 
            this.txt_Description.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Description.Location = new System.Drawing.Point(266, 204);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 20);
            this.txt_Description.TabIndex = 14;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quantity.Location = new System.Drawing.Point(141, 244);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(63, 20);
            this.lbl_quantity.TabIndex = 17;
            this.lbl_quantity.Text = "Miktar:";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Quantity.Location = new System.Drawing.Point(266, 244);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(200, 20);
            this.txt_Quantity.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ücret";
            // 
            // txt_Price
            // 
            this.txt_Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Price.Location = new System.Drawing.Point(266, 280);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(200, 20);
            this.txt_Price.TabIndex = 31;
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_Description);
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
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
    }
}