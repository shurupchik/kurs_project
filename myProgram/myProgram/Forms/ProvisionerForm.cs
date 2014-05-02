using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace myProgram
{
    public partial class ProvisionerForm : Form
    {
        public ProvisionerForm()
        {
            InitializeComponent();
        }

        private void ProvisionerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdProvForm form = new AddEdProvForm();
            provisionerBindingSource.AddNew();

            form.provisionerBindingSource.DataSource = provisionerBindingSource;
            form.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter.Update(this.myDataBaseDataSet.Provisioner);
                this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);
                dgvProv.CurrentCell = dgvProv.Rows[provisionerBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdProvForm form = new AddEdProvForm();

            form.provisionerBindingSource.DataSource = provisionerBindingSource;
            form.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter.Update(this.myDataBaseDataSet.Provisioner);
                int index = dgvProv.CurrentRow.Index;
                this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);
                dgvProv.CurrentCell = dgvProv.Rows[index].Cells[2];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectStr = @"Data Source=.\NO;AttachDbFilename=C:\Users\User\Documents\GitHub\kurs_project\myDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlDataAdapter daMerch = new SqlDataAdapter("Select * from Merchandise", connectStr);
            DataSet ds = new DataSet();
            daMerch.Fill(ds, "Merchandise");
            DataTable dtMerch = ds.Tables["Merchandise"];

            myProgram.myDataBaseDataSet.ProvisionerRow row = (myProgram.myDataBaseDataSet.ProvisionerRow)((DataRowView)provisionerBindingSource.Current).Row;

            var c = dtMerch.AsEnumerable()
                .Where(t => t.Field<int>("provId") == row.id)
                .Select(t => t);

            if (c.Count() == 0)
            {
                provisionerBindingSource.RemoveCurrent();
                provisionerBindingSource.EndEdit();
                provisionerTableAdapter.Update(myDataBaseDataSet.Provisioner);
            }
            else
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
