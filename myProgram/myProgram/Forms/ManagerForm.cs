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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.myDataBaseDataSet.Manager);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdManagerForm form = new AddEdManagerForm();
            managerBindingSource.AddNew();

            form.managerBindingSource.DataSource = managerBindingSource;
            form.managerBindingSource.Position = managerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                managerTableAdapter.Update(myDataBaseDataSet.Manager);
            }
        }

    }
}
