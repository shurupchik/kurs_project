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
                provisionerTableAdapter.Update(this.myDataBaseDataSet.Provisioner);
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdProvForm form = new AddEdProvForm();

            form.provisionerBindingSource.DataSource = provisionerBindingSource;
            form.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
                provisionerTableAdapter.Update(this.myDataBaseDataSet.Provisioner);
        }

    }
}
