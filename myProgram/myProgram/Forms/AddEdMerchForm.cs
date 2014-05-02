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
    public partial class AddEdMerchForm : Form
    {
        public AddEdMerchForm()
        {
            InitializeComponent();
        }

        private void AddEdMerchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Merchandise". При необходимости она может быть перемещена или удалена.
            this.merchandiseTableAdapter.Fill(this.myDataBaseDataSet.Merchandise);

        }

        private void AddEdMerchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                merchandiseBindingSource.EndEdit();
            else
                merchandiseBindingSource.CancelEdit();
        }
    }
}
