using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using System;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules.DrugStock
{
    internal partial class EditDrug : Form
    {
        public event EventHandler DrugUpdated;
        private DrugQueries drugQueries = new DrugQueries();

        internal EditDrug(Drug drug)
        {
            InitializeComponent();
            LoadInputFields(drug);
        }

        private void LoadInputFields(Drug drug)
        {
            if (drug.Id <= 0)
            {
                MessageBox.Show(@"Drug Id cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            txt_DrugId.Text = drug.Id.ToString();
            txt_DrugName.Text = drug.Name.ToString();
            txt_Barcode.Text = drug.Barcode.ToString();
            txt_Description.Text = drug.Description.ToString();
            txt_Quantity.Text = drug.Quantity.ToString();
            txt_Price.Text = drug.Price.ToString();
        }

        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DrugName.Text) || string.IsNullOrWhiteSpace(txt_Barcode.Text) || string.IsNullOrWhiteSpace(txt_Quantity.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            int drugId = Convert.ToInt32(txt_DrugId.Text);
            string drugName = txt_DrugName.Text.Trim();
            long barcode = Convert.ToInt64(txt_Barcode.Text.Trim());
            string description = txt_Description.Text.Trim();
            int quantity = Convert.ToInt32(txt_Quantity.Text.Trim());
            decimal price = Convert.ToDecimal(txt_Price.Text.Trim());

            bool result = drugQueries.UpdateDrug(new Drug(drugId, drugName, description, quantity, barcode, price));
            if (!result)
            {
                MessageBox.Show("Drug update process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DrugUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
