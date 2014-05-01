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
    public partial class AddEdProvForm : Form
    {
        public AddEdProvForm()
        {
            InitializeComponent();
        }

        private void AddEdProvForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);

        }

        private void AddEdProvForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                provisionerBindingSource.EndEdit();
            else
                provisionerBindingSource.CancelEdit();
        }
    }
}
