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
            {
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
                this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);
                dgvCategory.CurrentCell = dgvCategory.Rows[categoryBindingSource.Count - 1].Cells[1];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdCategoryForm form = new AddEdCategoryForm();

            form.categoryBindingSource.DataSource = categoryBindingSource;
            form.categoryBindingSource.Position = categoryBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
                int index = dgvCategory.CurrentRow.Index;
                this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);
                dgvCategory.CurrentCell = dgvCategory.Rows[index].Cells[1];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectStr = @"Data Source=.\NO;AttachDbFilename=C:\Users\User\Documents\GitHub\kurs_project\myDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlDataAdapter daMerch = new SqlDataAdapter("Select * from Merchandise", connectStr);
            DataSet ds = new DataSet();
            daMerch.Fill(ds, "Merchandise");
            DataTable dtMerch = ds.Tables["Merchandise"];

            myProgram.myDataBaseDataSet.CategoryRow row = (myProgram.myDataBaseDataSet.CategoryRow)((DataRowView)categoryBindingSource.Current).Row;

            var c = dtMerch.AsEnumerable()
                .Where(t => t.Field<int>("categoryId") == row.id)
                .Select(t => t);

            if (c.Count() == 0)
            {
                categoryBindingSource.RemoveCurrent();
                categoryBindingSource.EndEdit();
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
            }
            else
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
