using EczaneDepoDB.Modules;
using EczaneDepoDB.Modules.Prescription;
using System;
using System.Windows.Forms;

namespace EczaneDepoDB
{
    public partial class EczaneDepoDB : Form
    {
        internal DrugStore DrugStoreForm;
        public EczaneDepoDB()
        {
            InitializeComponent();
        }

        private void updateStock_Click(object sender, EventArgs e)
        {
            DrugStoreForm = new DrugStore();
            DrugStoreForm.Show();
        }

        private void btn_createReceipt_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.FormClosed += (s, args) => this.Close();
            prescription.Show();
            this.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
