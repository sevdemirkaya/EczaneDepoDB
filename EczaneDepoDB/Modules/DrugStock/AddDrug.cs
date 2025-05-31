using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using System;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules.DrugStock
{
    public partial class AddDrug : Form
    {
        public event EventHandler DrugUpdated;
        private DrugQueries drugQueries = new DrugQueries();
        public AddDrug()
        {
            InitializeComponent();
        }

        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DrugName.Text) || string.IsNullOrWhiteSpace(txt_Barcode.Text) || string.IsNullOrWhiteSpace(txt_Quantity.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Convert.ToDecimal(txt_Price.Text.Trim());
                Convert.ToInt64(txt_Barcode.Text.Trim());
                Convert.ToInt32(txt_Quantity.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Barcode, quantity and price field must be integer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string drugName = txt_DrugName.Text.Trim();
            string description = txt_Description.Text.Trim();
            int quantity = Convert.ToInt32(txt_Quantity.Text.Trim());
            long barcode= Convert.ToInt64(txt_Barcode.Text);
            decimal price = Convert.ToDecimal(txt_Price.Text.Trim());

            Drug drug = new Drug(drugName, description, quantity, barcode, price);

            bool result = drugQueries.InsertDrug(drug);
            if (!result)
            {
                MessageBox.Show("Drug insert process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DrugUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void AddDrug_Load(object sender, EventArgs e)
        {

        }
    }
}
