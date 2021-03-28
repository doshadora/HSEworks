namespace courseWork2
{
    partial class Statistics
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
            this.statGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.uploadWordButton = new System.Windows.Forms.Button();
            this.uploadExcelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSecond = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statGrid
            // 
            this.statGrid.AllowUserToAddRows = false;
            this.statGrid.AllowUserToDeleteRows = false;
            this.statGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.statGrid.Location = new System.Drawing.Point(191, 46);
            this.statGrid.Name = "statGrid";
            this.statGrid.ReadOnly = true;
            this.statGrid.RowHeadersVisible = false;
            this.statGrid.Size = new System.Drawing.Size(597, 356);
            this.statGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Город";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Пол";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 52;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Категория";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Кол-во проданных товаров";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 116;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Сумма выручки";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статистика по выполненным заказам";
            // 
            // dateFirst
            // 
            this.dateFirst.Location = new System.Drawing.Point(37, 48);
            this.dateFirst.Name = "dateFirst";
            this.dateFirst.Size = new System.Drawing.Size(148, 20);
            this.dateFirst.TabIndex = 3;
            this.dateFirst.ValueChanged += new System.EventHandler(this.DateFirst_ValueChanged);
            // 
            // uploadWordButton
            // 
            this.uploadWordButton.Enabled = false;
            this.uploadWordButton.Location = new System.Drawing.Point(12, 319);
            this.uploadWordButton.Name = "uploadWordButton";
            this.uploadWordButton.Size = new System.Drawing.Size(173, 23);
            this.uploadWordButton.TabIndex = 4;
            this.uploadWordButton.Text = "Загрузить отчет в MS Word";
            this.uploadWordButton.UseVisualStyleBackColor = true;
            this.uploadWordButton.Click += new System.EventHandler(this.UploadWordButton_Click);
            // 
            // uploadExcelButton
            // 
            this.uploadExcelButton.Enabled = false;
            this.uploadExcelButton.Location = new System.Drawing.Point(12, 350);
            this.uploadExcelButton.Name = "uploadExcelButton";
            this.uploadExcelButton.Size = new System.Drawing.Size(173, 23);
            this.uploadExcelButton.TabIndex = 5;
            this.uploadExcelButton.Text = "Загрузить отчет в MS Excel";
            this.uploadExcelButton.UseVisualStyleBackColor = true;
            this.uploadExcelButton.Click += new System.EventHandler(this.UploadExcelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "c";
            // 
            // dateSecond
            // 
            this.dateSecond.Enabled = false;
            this.dateSecond.Location = new System.Drawing.Point(37, 75);
            this.dateSecond.Name = "dateSecond";
            this.dateSecond.Size = new System.Drawing.Size(148, 20);
            this.dateSecond.TabIndex = 7;
            this.dateSecond.ValueChanged += new System.EventHandler(this.DateSecond_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "до";
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Enabled = false;
            this.applyFilterButton.Location = new System.Drawing.Point(12, 101);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(173, 23);
            this.applyFilterButton.TabIndex = 11;
            this.applyFilterButton.Text = "Применить фильтр";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Location = new System.Drawing.Point(12, 379);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(173, 23);
            this.goBackToMainButton.TabIndex = 12;
            this.goBackToMainButton.Text = "Вернуться в главное меню";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
            this.goBackToMainButton.Click += new System.EventHandler(this.GoBackToMainButton_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.goBackToMainButton);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadExcelButton);
            this.Controls.Add(this.uploadWordButton);
            this.Controls.Add(this.dateFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statGrid);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.Button uploadWordButton;
        private System.Windows.Forms.Button uploadExcelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Button goBackToMainButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}