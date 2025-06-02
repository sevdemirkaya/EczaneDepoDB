using EczaneDepoDB.Modal.DataAccess;
using EczaneDepoDB.Modal.Queries;
using EczaneDepoDB.Modules.DrugStock;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace EczaneDepoDB.Modules.Prescription
{
    public partial class Prescription : Form
    {
        private readonly PrescriptionQueries PrescriptionQueries = new PrescriptionQueries();
        public Prescription()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Prescription_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_NationalID.Text))
            {
                MessageBox.Show("Kimlik numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modal.DataAccess.Prescription prec = PrescriptionQueries.GetByNationalId(txt_NationalID.Text);
            if(prec == null)
            {
                MessageBox.Show("Reçete bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Receipt receiptForm = new Receipt(prec);
            receiptForm.FormClosed += (s, args) => this.Show();
            receiptForm.Show();
            this.Hide();
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
