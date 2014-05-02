﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myProgram
{
    public partial class AddEdManagerForm : Form
    {
        public AddEdManagerForm()
        {
            InitializeComponent();
        }

        private void AddEdManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.myDataBaseDataSet.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.myDataBaseDataSet.Manager);
        }

        private void AddEdManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                managerBindingSource.EndEdit();
            else
                managerBindingSource.CancelEdit();
        }
    }
}
