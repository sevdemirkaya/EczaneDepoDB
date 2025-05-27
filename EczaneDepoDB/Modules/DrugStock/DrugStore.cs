using EczaneDepoDB.Modal.Queries;
using EczaneDepoDB.Modules.DrugStock;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules
{
    public partial class DrugStore : Form
    {

        private AddDrug AddDrugForm = new AddDrug();
        private EditDrug EditDrugForm = new EditDrug();
        private DrugStockQueries DrugStockQueries = new DrugStockQueries();

        public DrugStore()
        {
            InitializeComponent();
            LoadDrugData();
        }

        private void LoadDrugData()
        {
            DataTable dataSource = DrugStockQueries.GetDrugData();
            dg_DrugStore.AutoGenerateColumns = true;
            dg_DrugStore.DataSource = dataSource;
        }

        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            AddDrugForm.Show();
        }

        private void btn_drugUpdate_Click(object sender, EventArgs e)
        {
            EditDrugForm.Show();
        }
    }


}




