namespace EczaneDepoDB
{
    partial class EczaneDepoDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_viewDrugStock = new System.Windows.Forms.Button();
            this.btn_createReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buradan Eczanenize İlaç Kontrolü Yapabilirsiniz";
            // 
            // btn_viewDrugStock
            // 
            this.btn_viewDrugStock.Location = new System.Drawing.Point(692, 157);
            this.btn_viewDrugStock.Name = "btn_viewDrugStock";
            this.btn_viewDrugStock.Size = new System.Drawing.Size(99, 23);
            this.btn_viewDrugStock.TabIndex = 6;
            this.btn_viewDrugStock.Text = "View Drug Stock";
            this.btn_viewDrugStock.UseVisualStyleBackColor = true;
            this.btn_viewDrugStock.Click += new System.EventHandler(this.updateStock_Click);
            // 
            // btn_createReceipt
            // 
            this.btn_createReceipt.Location = new System.Drawing.Point(683, 282);
            this.btn_createReceipt.Name = "btn_createReceipt";
            this.btn_createReceipt.Size = new System.Drawing.Size(135, 23);
            this.btn_createReceipt.TabIndex = 10;
            this.btn_createReceipt.Text = "Create Receipt";
            this.btn_createReceipt.UseVisualStyleBackColor = true;
            this.btn_createReceipt.Click += new System.EventHandler(this.btn_createReceipt_Click);
            // 
            // EczaneDepoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 898);
            this.Controls.Add(this.btn_createReceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewDrugStock);
            this.Name = "EczaneDepoDB";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_viewDrugStock;
        private System.Windows.Forms.Button btn_createReceipt;

    }
}

