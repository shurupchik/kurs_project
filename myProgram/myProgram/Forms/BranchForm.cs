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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
            else
            { 
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();
            if (form.ShowDialog() == DialogResult.OK)
            { }
            else
            { }
        }
    }
}
