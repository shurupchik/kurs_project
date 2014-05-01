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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.myDataBaseDataSet.Branch);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();
            branchBindingSource.AddNew();

            form.branchBindingSource.DataSource = branchBindingSource;
            form.branchBindingSource.Position = branchBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
                branchTableAdapter.Update(myDataBaseDataSet.Branch);
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();

            form.branchBindingSource.DataSource = branchBindingSource;
            form.branchBindingSource.Position = branchBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
                branchTableAdapter.Update(myDataBaseDataSet.Branch);
        }  
    }
}
