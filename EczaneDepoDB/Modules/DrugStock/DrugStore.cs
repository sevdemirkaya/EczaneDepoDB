using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using EczaneDepoDB.Modules.DrugStock;
using EczaneDepoDB.Modules.Prescription;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules
{
    public partial class DrugStore : Form
    {

        private AddDrug addDrugForm = new AddDrug();
        private DrugQueries drugQueries = new DrugQueries();

        public DrugStore()
        {
            InitializeComponent();
        }

        private void LoadDrugData()
        {
            DataTable dataSource = drugQueries.GetDrugData();
            dg_DrugStore.AutoGenerateColumns = true;
            dg_DrugStore.DataSource = dataSource;
        }

        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            addDrugForm.DrugUpdated += (s, args) =>
            {
                LoadDrugData();
            };
            addDrugForm.FormClosed += (s, args) => this.Show();
            addDrugForm.Show();
            this.Hide();
        }

        private void btn_drugUpdate_Click(object sender, EventArgs e)
        {
            if (dg_DrugStore.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select a drug", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dg_DrugStore.SelectedRows[0];

            // Verileri satırdan çek
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string name = selectedRow.Cells["Name"].Value.ToString();
            string description = selectedRow.Cells["Description"].Value.ToString();
            int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
            long barcode= Convert.ToInt64(selectedRow.Cells["Barcode"].Value);
            decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

            Drug drug = new Drug(id, name, description, quantity, barcode, price);

            EditDrug editDrugForm = new EditDrug(drug);
            editDrugForm.DrugUpdated += (s, args) =>
            {
                LoadDrugData(); 
            };
            editDrugForm.FormClosed += (s, args) => this.Show();
            editDrugForm.Show();
            this.Hide();
        }

        private void event_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Are you sure you want to delete the selected drug?",
    "Delete Confirmation",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true; // cancel deletion
                return;
            }

            // Optionally delete from the database
            int id = Convert.ToInt32(e.Row.Cells["Id"].Value);
            bool isDeleted = drugQueries.DeleteDrug(id);
            if (!isDeleted)
            {
                MessageBox.Show("Failed to delete from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void DrugStore_Load(object sender, EventArgs e)
        {
            LoadDrugData();
        }
    }

    


}




