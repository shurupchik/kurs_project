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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.dgvManager". При необходимости она может быть перемещена или удалена.
            this.dgvManagerTableAdapter.Fill(this.myDataBaseDataSet.dgvManager);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdManagerForm form = new AddEdManagerForm();
            dgvManagerBindingSource.AddNew();

            form.managerBindingSource.DataSource = dgvManagerBindingSource;
            form.managerBindingSource.Position = dgvManagerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvManagerTableAdapter.Update(myDataBaseDataSet.dgvManager);
                this.dgvManagerTableAdapter.Fill(this.myDataBaseDataSet.dgvManager);
                dgvManager.CurrentCell = dgvManager.Rows[dgvManagerBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdManagerForm form = new AddEdManagerForm();

            form.managerBindingSource.DataSource = dgvManagerBindingSource;
            form.managerBindingSource.Position = dgvManagerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvManagerTableAdapter.Update(myDataBaseDataSet.dgvManager);
                int index = dgvManager.CurrentRow.Index;
                this.dgvManagerTableAdapter.Fill(this.myDataBaseDataSet.dgvManager);
                dgvManager.CurrentCell = dgvManager.Rows[index].Cells[2];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvManagerBindingSource.RemoveCurrent();
            dgvManagerBindingSource.EndEdit();
            dgvManagerTableAdapter.Update(myDataBaseDataSet.dgvManager);   
        }  
    }
}
