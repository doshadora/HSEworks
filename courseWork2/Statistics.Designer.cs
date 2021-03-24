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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.uploadWordButton = new System.Windows.Forms.Button();
            this.uploadExcelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSecond = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 356);
            this.dataGridView1.TabIndex = 0;
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
            this.dateFirst.Visible = false;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "c";
            this.label2.Visible = false;
            // 
            // dateSecond
            // 
            this.dateSecond.Location = new System.Drawing.Point(37, 75);
            this.dateSecond.Name = "dateSecond";
            this.dateSecond.Size = new System.Drawing.Size(148, 20);
            this.dateSecond.TabIndex = 7;
            this.dateSecond.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "до";
            this.label3.Visible = false;
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
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Enabled = false;
            this.goBackToMainButton.Location = new System.Drawing.Point(12, 379);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(173, 23);
            this.goBackToMainButton.TabIndex = 12;
            this.goBackToMainButton.Text = "Вернуться в главное меню";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.Button uploadWordButton;
        private System.Windows.Forms.Button uploadExcelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Button goBackToMainButton;
    }
}