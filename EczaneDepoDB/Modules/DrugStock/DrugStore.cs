using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using EczaneDepoDB.Modules.DrugStock;
using EczaneDepoDB.Modules.Prescription;
using System;
using System.Data;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules
{
    public partial class DrugStore : Form
    {
        private AddDrug addDrugForm = new AddDrug();
        private DrugQueries drugQueries = new DrugQueries();
        private BindingSource bindingSource = new BindingSource();
        private DataTable drugTable;

        public DrugStore()
        {
            InitializeComponent();
        }

        private void LoadDrugData()
        {
            drugTable = drugQueries.GetDrugData();
            bindingSource.DataSource = drugTable;
            dg_DrugStore.AutoGenerateColumns = true;
            dg_DrugStore.DataSource = bindingSource;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text.Trim().Replace("'", "''");

            bindingSource.Filter = $"Name LIKE '%{searchValue}%' OR " +
                                   $"Description LIKE '%{searchValue}%' OR " +
                                   $"CONVERT(Barcode, System.String) LIKE '%{searchValue}%'";
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

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string name = selectedRow.Cells["Name"].Value.ToString();
            string description = selectedRow.Cells["Description"].Value.ToString();
            int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
            long barcode = Convert.ToInt64(selectedRow.Cells["Barcode"].Value);
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
                e.Cancel = true;
                return;
            }

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
            txt_Search.TextChanged += txt_Search_TextChanged;
        }
    }
}
