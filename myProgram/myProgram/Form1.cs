using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myProgram
{
    public partial class btnReportMerch : Form
    {
        public btnReportMerch()
        {
            InitializeComponent();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            branchForm.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            ProvisionerForm provForm = new ProvisionerForm();
            provForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void btnMerch_Click(object sender, EventArgs e)
        {
            MerchForm merchForm = new MerchForm();
            merchForm.Show();
        }
    }
}
