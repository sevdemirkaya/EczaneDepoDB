using EczaneDepoDB.Modal.Queries;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules.DrugStock
{
    public partial class AddDrug : Form
    {
    
        private DrugStockQueries drugStockQueries = new DrugStockQueries();
        public AddDrug()
        {
            InitializeComponent();
        }

        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DrugName.Text) || string.IsNullOrWhiteSpace(txt_Barcode.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string drugName = txt_DrugName.Text.Trim();
            string barcode = txt_Barcode.Text.Trim();
            bool result = drugStockQueries.InsertDrug(drugName, barcode);
            if (!result)
            {
                MessageBox.Show("İlaç eklenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
