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
    public partial class AddEdCategoryForm : Form
    {
        public AddEdCategoryForm()
        {
            InitializeComponent();
        }

        private void AddEdCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);

        }

        private void AddEdCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                categoryBindingSource.EndEdit();
            else
                categoryBindingSource.CancelEdit();
        }
    }
}
