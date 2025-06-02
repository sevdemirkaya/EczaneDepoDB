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
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugStore)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_DrugStore
            // 
            this.dg_DrugStore.AllowUserToAddRows = false;
            this.dg_DrugStore.AllowUserToOrderColumns = true;
            this.dg_DrugStore.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dg_DrugStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DrugStore.Location = new System.Drawing.Point(89, 122);
            this.dg_DrugStore.Name = "dg_DrugStore";
            this.dg_DrugStore.ReadOnly = true;
            this.dg_DrugStore.Size = new System.Drawing.Size(761, 245);
            this.dg_DrugStore.TabIndex = 0;
            this.dg_DrugStore.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.event_UserDeletingRow);
            // 
            // btn_AddDrug
            // 
            this.btn_AddDrug.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddDrug.Location = new System.Drawing.Point(89, 50);
            this.btn_AddDrug.Name = "btn_AddDrug";
            this.btn_AddDrug.Size = new System.Drawing.Size(295, 23);
            this.btn_AddDrug.TabIndex = 1;
            this.btn_AddDrug.Text = "İlaç Ekle";
            this.btn_AddDrug.UseVisualStyleBackColor = false;
            this.btn_AddDrug.Click += new System.EventHandler(this.btn_AddDrug_Click);
            // 
            // btn_drugUpdate
            // 
            this.btn_drugUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_drugUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_drugUpdate.Location = new System.Drawing.Point(541, 50);
            this.btn_drugUpdate.Name = "btn_drugUpdate";
            this.btn_drugUpdate.Size = new System.Drawing.Size(309, 23);
            this.btn_drugUpdate.TabIndex = 2;
            this.btn_drugUpdate.Text = "İlaç Güncelle";
            this.btn_drugUpdate.UseVisualStyleBackColor = false;
            this.btn_drugUpdate.Click += new System.EventHandler(this.btn_drugUpdate_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(670, 96);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(180, 20);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // DrugStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_drugUpdate);
            this.Controls.Add(this.btn_AddDrug);
            this.Controls.Add(this.dg_DrugStore);
            this.Name = "DrugStore";
            this.Text = "DrugStore";
            this.Load += new System.EventHandler(this.DrugStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DrugStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_DrugStore;
        private System.Windows.Forms.Button btn_AddDrug;
        private System.Windows.Forms.Button btn_drugUpdate;
        private System.Windows.Forms.TextBox txt_Search;
    }
}