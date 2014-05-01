namespace myProgram
{
    partial class ProvisionerForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdition = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.myDataBaseDataSet = new myProgram.myDataBaseDataSet();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provisionerTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.ProvisionerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(262, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdition
            // 
            this.btnEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdition.Location = new System.Drawing.Point(137, 12);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(119, 28);
            this.btnEdition.TabIndex = 7;
            this.btnEdition.Text = "Редактировать";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.btnEdition_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProv
            // 
            this.dgvProv.AllowUserToAddRows = false;
            this.dgvProv.AllowUserToDeleteRows = false;
            this.dgvProv.AutoGenerateColumns = false;
            this.dgvProv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.agentDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvProv.DataSource = this.provisionerBindingSource;
            this.dgvProv.Location = new System.Drawing.Point(13, 47);
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.ReadOnly = true;
            this.dgvProv.Size = new System.Drawing.Size(759, 503);
            this.dgvProv.TabIndex = 9;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provisionerBindingSource
            // 
            this.provisionerBindingSource.DataMember = "Provisioner";
            this.provisionerBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // provisionerTableAdapter
            // 
            this.provisionerTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
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
            // agentDataGridViewTextBoxColumn
            // 
            this.agentDataGridViewTextBoxColumn.DataPropertyName = "agent";
            this.agentDataGridViewTextBoxColumn.HeaderText = "ФИО представителя";
            this.agentDataGridViewTextBoxColumn.Name = "agentDataGridViewTextBoxColumn";
            this.agentDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Е-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // ProvisionerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvProv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.btnAdd);
            this.Name = "ProvisionerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр поставщиков";
            this.Load += new System.EventHandler(this.ProvisionerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProv;
        private myDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource provisionerBindingSource;
        public myDataBaseDataSetTableAdapters.ProvisionerTableAdapter provisionerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}