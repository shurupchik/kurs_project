namespace myProgram
{
    partial class AddEdMerchForm
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
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtno = new System.Windows.Forms.TextBox();
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new myProgram.myDataBaseDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.merchandiseTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.MerchandiseTableAdapter();
            this.categoryTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.CategoryTableAdapter();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provisionerTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.ProvisionerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCansel
            // 
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(412, 113);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 20;
            this.btnCansel.Text = "Cancel";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(331, 113);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поставщик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Категория";
            // 
            // txtArtno
            // 
            this.txtArtno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.merchandiseBindingSource, "artno", true));
            this.txtArtno.Location = new System.Drawing.Point(133, 86);
            this.txtArtno.Name = "txtArtno";
            this.txtArtno.Size = new System.Drawing.Size(354, 20);
            this.txtArtno.TabIndex = 14;
            // 
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataMember = "Merchandise";
            this.merchandiseBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.merchandiseBindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(133, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 20);
            this.txtName.TabIndex = 13;
            // 
            // cbCategory
            // 
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.merchandiseBindingSource, "categoryId", true));
            this.cbCategory.DataSource = this.categoryBindingSource;
            this.cbCategory.DisplayMember = "name";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(133, 7);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(354, 21);
            this.cbCategory.TabIndex = 21;
            this.cbCategory.ValueMember = "id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // cbBranch
            // 
            this.cbBranch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.merchandiseBindingSource, "provId", true));
            this.cbBranch.DataSource = this.provisionerBindingSource;
            this.cbBranch.DisplayMember = "name";
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(133, 34);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(354, 21);
            this.cbBranch.TabIndex = 22;
            this.cbBranch.ValueMember = "id";
            // 
            // merchandiseTableAdapter
            // 
            this.merchandiseTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
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
            // AddEdMerchForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCansel;
            this.ClientSize = new System.Drawing.Size(494, 142);
            this.ControlBox = false;
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtno);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEdMerchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить/Редактировать товар";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEdMerchForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEdMerchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBranch;
        public myDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource merchandiseBindingSource;
        public myDataBaseDataSetTableAdapters.MerchandiseTableAdapter merchandiseTableAdapter;
        public System.Windows.Forms.BindingSource categoryBindingSource;
        public myDataBaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        public System.Windows.Forms.BindingSource provisionerBindingSource;
        public myDataBaseDataSetTableAdapters.ProvisionerTableAdapter provisionerTableAdapter;
    }
}