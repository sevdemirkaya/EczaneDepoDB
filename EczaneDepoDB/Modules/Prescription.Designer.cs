﻿namespace EczaneDepoDB.Modules.Prescription
{
    partial class Prescription
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
            this.txt_NationalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Prescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NationalID
            // 
            this.txt_NationalID.Location = new System.Drawing.Point(191, 172);
            this.txt_NationalID.MaxLength = 11;
            this.txt_NationalID.Name = "txt_NationalID";
            this.txt_NationalID.Size = new System.Drawing.Size(395, 20);
            this.txt_NationalID.TabIndex = 0;
            this.txt_NationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NationalID.TextChanged += new System.EventHandler(this.integerOnlyTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC KİMLİK GİRİNİZ.";
            // 
            // btn_Prescription
            // 
            this.btn_Prescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Prescription.Location = new System.Drawing.Point(321, 220);
            this.btn_Prescription.Name = "btn_Prescription";
            this.btn_Prescription.Size = new System.Drawing.Size(120, 34);
            this.btn_Prescription.TabIndex = 2;
            this.btn_Prescription.Text = "Reçete Bul";
            this.btn_Prescription.UseVisualStyleBackColor = false;
            this.btn_Prescription.Click += new System.EventHandler(this.btn_Prescription_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 419);
            this.Controls.Add(this.btn_Prescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NationalID);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NationalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Prescription;
    }
}