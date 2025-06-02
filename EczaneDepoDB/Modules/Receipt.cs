using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneDepoDB.Modules.Prescription
{
    public partial class Receipt : Form
    {
        private static readonly PrescriptionQueries prescriptionQueries = new PrescriptionQueries();
        private static readonly ReceiptQueries receiptQueries = new ReceiptQueries();
        private static readonly DrugQueries drugQueries = new DrugQueries();
        private static Modal.DataAccess.Prescription prescription = new Modal.DataAccess.Prescription();

        internal Receipt(Modal.DataAccess.Prescription prec)
        {
            InitializeComponent();
            prescription = prec;
            LoadReceipt(prec);
        }

        private void LoadReceipt(Modal.DataAccess.Prescription prec)
        {
            txt_NationalId.Text = prec.NationalId;
            dg_DrugList.AutoGenerateColumns = true;
            dg_DrugList.DataSource = LoadDrugList(prec.DrugList);
        }

        private DataTable LoadDrugList(List<Drug> drugList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Drug Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Barcode", typeof(decimal));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            decimal receiptTotalPrice = 0;
            foreach (var d in drugList)
            {
                var drug = drugQueries.GetDrugById(d.Id);
                if (drug != null)
                {
                    decimal total = drug.Price * d.Quantity;
                    receiptTotalPrice += total;
                    dt.Rows.Add(drug.Id, drug.Name, d.Quantity, drug.Barcode, drug.Price, total);
                }
            }
            txt_TotalPrice.Text = receiptTotalPrice.ToString();

            return dt;
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var receipt = new Modal.DataAccess.Receipt(
                prescription.Id,
                Convert.ToDecimal(txt_TotalPrice.Text),
                Convert.ToInt64(txt_Phone.Text)
            );

            bool insertResult = receiptQueries.InsertReceipt(receipt);
            if (insertResult)
            {
                bool changeStatusResult = prescriptionQueries.ChangeStatus(receipt);

                if (changeStatusResult)
                {
                    MessageBox.Show("Satın alma işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Satın alma işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void integerOnlyTextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;

            string originalText = textBox.Text;
            string sanitizedText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != sanitizedText)
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = sanitizedText;
                textBox.SelectionStart = sanitizedText.Length;
            }
        }

    }
}
