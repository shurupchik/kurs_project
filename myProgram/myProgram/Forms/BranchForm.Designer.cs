namespace myProgram
{
    partial class BranchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdition = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new myProgram.myDataBaseDataSet();
            this.branchTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.BranchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdition
            // 
            this.btnEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdition.Location = new System.Drawing.Point(137, 12);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(119, 28);
            this.btnEdition.TabIndex = 1;
            this.btnEdition.Text = "Редактировать";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.btnEdition_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(262, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvBranch
            // 
            this.dgvBranch.AllowUserToAddRows = false;
            this.dgvBranch.AllowUserToDeleteRows = false;
            this.dgvBranch.AutoGenerateColumns = false;
            this.dgvBranch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBranch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvBranch.DataSource = this.branchBindingSource;
            this.dgvBranch.Location = new System.Drawing.Point(12, 47);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.ReadOnly = true;
            this.dgvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBranch.Size = new System.Drawing.Size(760, 503);
            this.dgvBranch.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО начальника";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Е-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvBranch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.btnAdd);
            this.Name = "BranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр филиалов";
            this.Load += new System.EventHandler(this.BranchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvBranch;
        public System.Windows.Forms.BindingSource branchBindingSource;
        public myDataBaseDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public myDataBaseDataSet myDataBaseDataSet;
    }
}