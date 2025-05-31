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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(295, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buradan Eczanenize İlaç Stok Kontrolü Yapabilirsiniz";
            // 
            // btn_viewDrugStock
            // 
            this.btn_viewDrugStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_viewDrugStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_viewDrugStock.Location = new System.Drawing.Point(250, 235);
            this.btn_viewDrugStock.Name = "btn_viewDrugStock";
            this.btn_viewDrugStock.Size = new System.Drawing.Size(513, 62);
            this.btn_viewDrugStock.TabIndex = 6;
            this.btn_viewDrugStock.Text = "Eczane Stoklarını Görüntüle";
            this.btn_viewDrugStock.UseVisualStyleBackColor = false;
            this.btn_viewDrugStock.Click += new System.EventHandler(this.updateStock_Click);
            // 
            // btn_createReceipt
            // 
            this.btn_createReceipt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_createReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_createReceipt.Location = new System.Drawing.Point(250, 389);
            this.btn_createReceipt.Name = "btn_createReceipt";
            this.btn_createReceipt.Size = new System.Drawing.Size(513, 64);
            this.btn_createReceipt.TabIndex = 10;
            this.btn_createReceipt.Text = "Reçete Oluştur";
            this.btn_createReceipt.UseVisualStyleBackColor = false;
            this.btn_createReceipt.Click += new System.EventHandler(this.btn_createReceipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(348, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEMİRKAYA ECZANE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(401, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "1990\'DAN BERİ AİLENİZİN ECZANESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(249, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buradan kayıtlı reçetelere gidebilirsiniz ve fatura ödeyebilirsiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EczaneDepoDB.Properties.Resources.ChatGPT_Image_31_May_2025_13_45_32;
            this.pictureBox1.Location = new System.Drawing.Point(-71, -657);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EczaneDepoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createReceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewDrugStock);
            this.Name = "EczaneDepoDB";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_viewDrugStock;
        private System.Windows.Forms.Button btn_createReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

