namespace myProgram
{
    partial class AddEdProvForm
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.myDataBaseDataSet = new myProgram.myDataBaseDataSet();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provisionerTableAdapter = new myProgram.myDataBaseDataSetTableAdapters.ProvisionerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCansel
            // 
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(437, 113);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 20;
            this.btnCansel.Text = "Cancel";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(356, 113);
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
            this.label4.Location = new System.Drawing.Point(108, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "ФИО представителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provisionerBindingSource, "email", true));
            this.txtMail.Location = new System.Drawing.Point(160, 86);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(354, 20);
            this.txtMail.TabIndex = 14;
            // 
            // txtAgent
            // 
            this.txtAgent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provisionerBindingSource, "agent", true));
            this.txtAgent.Location = new System.Drawing.Point(160, 63);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(354, 20);
            this.txtAgent.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provisionerBindingSource, "address", true));
            this.txtAddress.Location = new System.Drawing.Point(160, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(354, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provisionerBindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(160, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 20);
            this.txtName.TabIndex = 11;
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
            // AddEdProvForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCansel;
            this.ClientSize = new System.Drawing.Size(524, 142);
            this.ControlBox = false;
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEdProvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление/Редактирвоание поставщика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEdProvForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEdProvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private myDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource provisionerBindingSource;
        public myDataBaseDataSetTableAdapters.ProvisionerTableAdapter provisionerTableAdapter;
    }
}