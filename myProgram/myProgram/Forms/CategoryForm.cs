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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdCategoryForm form = new AddEdCategoryForm();
            categoryBindingSource.AddNew();

            form.categoryBindingSource.DataSource = categoryBindingSource;
            form.categoryBindingSource.Position = categoryBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdCategoryForm form = new AddEdCategoryForm();

            form.categoryBindingSource.DataSource = categoryBindingSource;
            form.categoryBindingSource.Position = categoryBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
        }
    }
}
