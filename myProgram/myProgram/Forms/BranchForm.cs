using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;


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
            {
                branchTableAdapter.Update(myDataBaseDataSet.Branch);
                this.branchTableAdapter.Fill(this.myDataBaseDataSet.Branch);
                dgvBranch.CurrentCell = dgvBranch.Rows[branchBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();

            form.branchBindingSource.DataSource = branchBindingSource;
            form.branchBindingSource.Position = branchBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                branchTableAdapter.Update(myDataBaseDataSet.Branch);
                int index = dgvBranch.CurrentRow.Index;
                this.branchTableAdapter.Fill(this.myDataBaseDataSet.Branch);
                dgvBranch.CurrentCell = dgvBranch.Rows[index].Cells[2];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectStr = @"Data Source=.\NO;AttachDbFilename=C:\Users\User\Documents\GitHub\kurs_project\myDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlDataAdapter daManager = new SqlDataAdapter("Select * from Manager", connectStr);
            DataSet ds = new DataSet();
            daManager.Fill(ds, "Manager");
            DataTable dtManager = ds.Tables["Manager"];

            myProgram.myDataBaseDataSet.BranchRow row = (myProgram.myDataBaseDataSet.BranchRow)((DataRowView)branchBindingSource.Current).Row;

            var c = dtManager.AsEnumerable()
                .Where(t => t.Field<int>("branchId") == row.id)
                .Select(t => t);

            if (c.Count() == 0)
            {
                branchBindingSource.RemoveCurrent();
                branchBindingSource.EndEdit();
                branchTableAdapter.Update(this.myDataBaseDataSet.Branch);
            }
            else
            {
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}
