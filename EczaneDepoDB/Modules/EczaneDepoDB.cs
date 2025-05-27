using EczaneDepoDB.Modules;
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
    }
}
