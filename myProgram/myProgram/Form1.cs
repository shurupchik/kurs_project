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
    public partial class btnReportMerch : Form
    {
        public btnReportMerch()
        {
            InitializeComponent();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            branchForm.Show();
        }
    }
}
