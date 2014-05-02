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
    public partial class MerchForm : Form
    {
        public MerchForm()
        {
            InitializeComponent();
        }

        private void MerchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.dgvMerch". При необходимости она может быть перемещена или удалена.
            this.dgvMerchTableAdapter.Fill(this.myDataBaseDataSet.dgvMerch);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdMerchForm form = new AddEdMerchForm();
            dgvMerchBindingSource.AddNew();

            form.merchandiseBindingSource.DataSource = dgvMerchBindingSource;
            form.merchandiseBindingSource.Position = dgvMerchBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvMerchTableAdapter.Update(myDataBaseDataSet.dgvMerch);
                this.dgvMerchTableAdapter.Fill(this.myDataBaseDataSet.dgvMerch);
                dgvMerch.CurrentCell = dgvMerch.Rows[dgvMerchBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdMerchForm form = new AddEdMerchForm();

            form.merchandiseBindingSource.DataSource = dgvMerchBindingSource;
            form.merchandiseBindingSource.Position = dgvMerchBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvMerchTableAdapter.Update(myDataBaseDataSet.dgvMerch);
                int index = dgvMerch.CurrentRow.Index;
                this.dgvMerchTableAdapter.Fill(this.myDataBaseDataSet.dgvMerch);
                dgvMerch.CurrentCell = dgvMerch.Rows[index].Cells[2];
            }
        }
    }
}
