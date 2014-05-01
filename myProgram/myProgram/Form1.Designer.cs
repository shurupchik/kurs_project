namespace myProgram
{
    partial class btnReportMerch
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.nameAvatar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLists = new System.Windows.Forms.GroupBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnMerch = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnReportManager = new System.Windows.Forms.Button();
            this.btnReportBranch = new System.Windows.Forms.Button();
            this.btnReportProv = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnZakMerch = new System.Windows.Forms.Button();
            this.btnPereraspMerch = new System.Windows.Forms.Button();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.labelChooseBranch = new System.Windows.Forms.Label();
            this.cbChooseBranch = new System.Windows.Forms.ComboBox();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLists.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.nameAvatar);
            this.gbImage.Controls.Add(this.pictureBox1);
            this.gbImage.Location = new System.Drawing.Point(12, 5);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(257, 222);
            this.gbImage.TabIndex = 0;
            this.gbImage.TabStop = false;
            // 
            // nameAvatar
            // 
            this.nameAvatar.AutoSize = true;
            this.nameAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAvatar.Location = new System.Drawing.Point(22, 191);
            this.nameAvatar.Name = "nameAvatar";
            this.nameAvatar.Size = new System.Drawing.Size(213, 16);
            this.nameAvatar.TabIndex = 1;
            this.nameAvatar.Text = "Сеть торговых точек \"Магазин\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbLists
            // 
            this.gbLists.Controls.Add(this.btnSale);
            this.gbLists.Controls.Add(this.btnMerch);
            this.gbLists.Controls.Add(this.btnCategory);
            this.gbLists.Controls.Add(this.btnProv);
            this.gbLists.Controls.Add(this.btnManager);
            this.gbLists.Controls.Add(this.btnBranch);
            this.gbLists.Location = new System.Drawing.Point(12, 233);
            this.gbLists.Name = "gbLists";
            this.gbLists.Size = new System.Drawing.Size(257, 212);
            this.gbLists.TabIndex = 1;
            this.gbLists.TabStop = false;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(7, 166);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(244, 28);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Список продаж";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnMerch
            // 
            this.btnMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMerch.Location = new System.Drawing.Point(6, 136);
            this.btnMerch.Name = "btnMerch";
            this.btnMerch.Size = new System.Drawing.Size(244, 28);
            this.btnMerch.TabIndex = 4;
            this.btnMerch.Text = "Список товара";
            this.btnMerch.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.Location = new System.Drawing.Point(7, 107);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(244, 28);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Просмотр категорий товара";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProv
            // 
            this.btnProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProv.Location = new System.Drawing.Point(7, 79);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(244, 28);
            this.btnProv.TabIndex = 2;
            this.btnProv.Text = "Просмотр поставщиков";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManager.Location = new System.Drawing.Point(7, 49);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(244, 28);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Просмотр менеджеров";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBranch.Location = new System.Drawing.Point(6, 18);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(244, 28);
            this.btnBranch.TabIndex = 0;
            this.btnBranch.Text = "Просмотр филиалов";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnReportManager);
            this.gbReport.Controls.Add(this.btnReportBranch);
            this.gbReport.Controls.Add(this.btnReportProv);
            this.gbReport.Controls.Add(this.button7);
            this.gbReport.Location = new System.Drawing.Point(12, 451);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(257, 152);
            this.gbReport.TabIndex = 2;
            this.gbReport.TabStop = false;
            // 
            // btnReportManager
            // 
            this.btnReportManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportManager.Location = new System.Drawing.Point(7, 108);
            this.btnReportManager.Name = "btnReportManager";
            this.btnReportManager.Size = new System.Drawing.Size(244, 28);
            this.btnReportManager.TabIndex = 3;
            this.btnReportManager.Text = "Результативность менеджеров";
            this.btnReportManager.UseVisualStyleBackColor = true;
            // 
            // btnReportBranch
            // 
            this.btnReportBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportBranch.Location = new System.Drawing.Point(6, 78);
            this.btnReportBranch.Name = "btnReportBranch";
            this.btnReportBranch.Size = new System.Drawing.Size(244, 28);
            this.btnReportBranch.TabIndex = 2;
            this.btnReportBranch.Text = "Продаваемость по филиалам ";
            this.btnReportBranch.UseVisualStyleBackColor = true;
            // 
            // btnReportProv
            // 
            this.btnReportProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportProv.Location = new System.Drawing.Point(6, 48);
            this.btnReportProv.Name = "btnReportProv";
            this.btnReportProv.Size = new System.Drawing.Size(244, 28);
            this.btnReportProv.TabIndex = 1;
            this.btnReportProv.Text = "Популярность поставщиков";
            this.btnReportProv.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(7, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 28);
            this.button7.TabIndex = 0;
            this.button7.Text = "Продаваемость товара";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnZakMerch);
            this.gbMain.Controls.Add(this.btnPereraspMerch);
            this.gbMain.Controls.Add(this.dgvStorage);
            this.gbMain.Controls.Add(this.labelChooseBranch);
            this.gbMain.Controls.Add(this.cbChooseBranch);
            this.gbMain.Location = new System.Drawing.Point(275, 5);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(714, 598);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            // 
            // btnZakMerch
            // 
            this.btnZakMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZakMerch.Location = new System.Drawing.Point(464, 564);
            this.btnZakMerch.Name = "btnZakMerch";
            this.btnZakMerch.Size = new System.Drawing.Size(244, 28);
            this.btnZakMerch.TabIndex = 4;
            this.btnZakMerch.Text = "Заказать товар";
            this.btnZakMerch.UseVisualStyleBackColor = true;
            // 
            // btnPereraspMerch
            // 
            this.btnPereraspMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPereraspMerch.Location = new System.Drawing.Point(214, 564);
            this.btnPereraspMerch.Name = "btnPereraspMerch";
            this.btnPereraspMerch.Size = new System.Drawing.Size(244, 28);
            this.btnPereraspMerch.TabIndex = 3;
            this.btnPereraspMerch.Text = "Перераспределить товар";
            this.btnPereraspMerch.UseVisualStyleBackColor = true;
            // 
            // dgvStorage
            // 
            this.dgvStorage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Location = new System.Drawing.Point(6, 48);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.Size = new System.Drawing.Size(702, 510);
            this.dgvStorage.TabIndex = 2;
            // 
            // labelChooseBranch
            // 
            this.labelChooseBranch.AutoSize = true;
            this.labelChooseBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseBranch.Location = new System.Drawing.Point(7, 20);
            this.labelChooseBranch.Name = "labelChooseBranch";
            this.labelChooseBranch.Size = new System.Drawing.Size(194, 18);
            this.labelChooseBranch.TabIndex = 1;
            this.labelChooseBranch.Text = "Наличие товара на складе";
            // 
            // cbChooseBranch
            // 
            this.cbChooseBranch.FormattingEnabled = true;
            this.cbChooseBranch.Location = new System.Drawing.Point(237, 21);
            this.cbChooseBranch.Name = "cbChooseBranch";
            this.cbChooseBranch.Size = new System.Drawing.Size(471, 21);
            this.cbChooseBranch.TabIndex = 0;
            this.cbChooseBranch.Text = "Выберите филиал";
            // 
            // btnReportMerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 615);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbLists);
            this.Controls.Add(this.gbImage);
            this.Name = "btnReportMerch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеть торговых точек \"Магазин\"";
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLists.ResumeLayout(false);
            this.gbReport.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.GroupBox gbLists;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label nameAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnMerch;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnReportManager;
        private System.Windows.Forms.Button btnReportBranch;
        private System.Windows.Forms.Button btnReportProv;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnZakMerch;
        private System.Windows.Forms.Button btnPereraspMerch;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Label labelChooseBranch;
        private System.Windows.Forms.ComboBox cbChooseBranch;
    }
}

