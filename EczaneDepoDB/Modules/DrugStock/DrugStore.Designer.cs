using EczaneDepoDB.Modules.DrugStock;
using System;

namespace EczaneDepoDB.Modules
{
    partial class DrugStore
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
            this.dg_DrugStore = new System.Windows.Forms.DataGridView();
            this.btn_AddDrug = new System.Windows.Forms.Button();
            this.btn_drugUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugStore)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_DrugStore
            // 
            this.dg_DrugStore.AllowUserToAddRows = false;
            this.dg_DrugStore.AllowUserToOrderColumns = true;
            this.dg_DrugStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DrugStore.Location = new System.Drawing.Point(89, 99);
            this.dg_DrugStore.Name = "dg_DrugStore";
            this.dg_DrugStore.ReadOnly = true;
            this.dg_DrugStore.Size = new System.Drawing.Size(761, 245);
            this.dg_DrugStore.TabIndex = 0;
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.Location = new System.Drawing.Point(89, 50);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDrug.TabIndex = 1;
            this.btn_AddDrug.Text = "Add Drugs";
            this.btn_AddDrug.UseVisualStyleBackColor = true;
            this.btn_AddDrug.Click += new System.EventHandler(this.btn_AddDrug_Click);
            // 
            // btn_drugUpdate
            // 
            this.btn_drugUpdate.Location = new System.Drawing.Point(272, 50);
            this.btn_drugUpdate.Name = "btn_drugUpdate";
            this.btn_drugUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_drugUpdate.TabIndex = 2;
            this.btn_drugUpdate.Text = "button1";
            this.btn_drugUpdate.UseVisualStyleBackColor = true;
            this.btn_drugUpdate.Click += new System.EventHandler(this.btn_drugUpdate_Click);
            // 
            // DrugStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.btn_drugUpdate);
            this.Controls.Add(this.btn_AddDrug);
            this.Controls.Add(this.dg_DrugStore);
            this.Name = "DrugStore";
            this.Text = "DrugStore";
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_DrugStore;
        private System.Windows.Forms.Button btn_AddDrug;
        private System.Windows.Forms.Button btn_drugUpdate;
    }
}