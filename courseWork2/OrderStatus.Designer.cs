namespace courseWork2
{
    partial class OrderStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbChooseCity = new System.Windows.Forms.ComboBox();
            this.tbChooseStat = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStat = new System.Windows.Forms.Label();
            this.submitFilterButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.orderGroup = new System.Windows.Forms.GroupBox();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.changeStatGroup = new System.Windows.Forms.GroupBox();
            this.changeStatButton = new System.Windows.Forms.Button();
            this.tbCurrentStat = new System.Windows.Forms.TextBox();
            this.tbStatDate = new System.Windows.Forms.TextBox();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackToFilterButton = new System.Windows.Forms.Button();
            this.filterGroup.SuspendLayout();
            this.orderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.changeStatGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbChooseCity
            // 
            this.tbChooseCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChooseCity.FormattingEnabled = true;
            this.tbChooseCity.Location = new System.Drawing.Point(148, 38);
            this.tbChooseCity.Name = "tbChooseCity";
            this.tbChooseCity.Size = new System.Drawing.Size(141, 21);
            this.tbChooseCity.TabIndex = 2;
            // 
            // tbChooseStat
            // 
            this.tbChooseStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChooseStat.FormattingEnabled = true;
            this.tbChooseStat.Location = new System.Drawing.Point(148, 66);
            this.tbChooseStat.Name = "tbChooseStat";
            this.tbChooseStat.Size = new System.Drawing.Size(141, 21);
            this.tbChooseStat.TabIndex = 3;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(16, 38);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(52, 25);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Город";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.Location = new System.Drawing.Point(16, 66);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(105, 25);
            this.labelStat.TabIndex = 5;
            this.labelStat.Text = "Статус заказа";
            // 
            // submitFilterButton
            // 
            this.submitFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFilterButton.Location = new System.Drawing.Point(73, 108);
            this.submitFilterButton.Name = "submitFilterButton";
            this.submitFilterButton.Size = new System.Drawing.Size(162, 23);
            this.submitFilterButton.TabIndex = 6;
            this.submitFilterButton.Text = "Применить фильтр";
            this.submitFilterButton.UseVisualStyleBackColor = true;
            this.submitFilterButton.Click += new System.EventHandler(this.SubmitFilterButton_Click);
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Location = new System.Drawing.Point(387, 309);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(162, 23);
            this.goBackToMainButton.TabIndex = 7;
            this.goBackToMainButton.Text = "Вернуться в главное меню";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
            this.goBackToMainButton.Click += new System.EventHandler(this.GoBackToMainButton_Click);
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.tbChooseCity);
            this.filterGroup.Controls.Add(this.tbChooseStat);
            this.filterGroup.Controls.Add(this.submitFilterButton);
            this.filterGroup.Controls.Add(this.labelCity);
            this.filterGroup.Controls.Add(this.labelStat);
            this.filterGroup.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGroup.Location = new System.Drawing.Point(8, 39);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(304, 137);
            this.filterGroup.TabIndex = 8;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Фильтры";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(381, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 29);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "labelName";
            // 
            // orderGroup
            // 
            this.orderGroup.Controls.Add(this.orderGrid);
            this.orderGroup.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGroup.Location = new System.Drawing.Point(381, 39);
            this.orderGroup.Name = "orderGroup";
            this.orderGroup.Size = new System.Drawing.Size(577, 260);
            this.orderGroup.TabIndex = 10;
            this.orderGroup.TabStop = false;
            this.orderGroup.Text = "Выберите строку для изменения статуса";
            this.orderGroup.Visible = false;
            // 
            // orderGrid
            // 
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGrid.Location = new System.Drawing.Point(6, 22);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersVisible = false;
            this.orderGrid.Size = new System.Drawing.Size(562, 232);
            this.orderGrid.TabIndex = 0;
            this.orderGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderGrid_MouseClick);
            // 
            // changeStatGroup
            // 
            this.changeStatGroup.Controls.Add(this.changeStatButton);
            this.changeStatGroup.Controls.Add(this.tbCurrentStat);
            this.changeStatGroup.Controls.Add(this.tbStatDate);
            this.changeStatGroup.Controls.Add(this.tbOrderDate);
            this.changeStatGroup.Controls.Add(this.label3);
            this.changeStatGroup.Controls.Add(this.label2);
            this.changeStatGroup.Controls.Add(this.label1);
            this.changeStatGroup.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatGroup.Location = new System.Drawing.Point(8, 182);
            this.changeStatGroup.Name = "changeStatGroup";
            this.changeStatGroup.Size = new System.Drawing.Size(367, 166);
            this.changeStatGroup.TabIndex = 11;
            this.changeStatGroup.TabStop = false;
            this.changeStatGroup.Text = "Информация о статусе заказа";
            this.changeStatGroup.Visible = false;
            // 
            // changeStatButton
            // 
            this.changeStatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatButton.Location = new System.Drawing.Point(96, 127);
            this.changeStatButton.Name = "changeStatButton";
            this.changeStatButton.Size = new System.Drawing.Size(162, 23);
            this.changeStatButton.TabIndex = 6;
            this.changeStatButton.Text = "changeStatButton";
            this.changeStatButton.UseVisualStyleBackColor = true;
            this.changeStatButton.Visible = false;
            this.changeStatButton.Click += new System.EventHandler(this.ChangeStatButton_Click);
            // 
            // tbCurrentStat
            // 
            this.tbCurrentStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCurrentStat.Location = new System.Drawing.Point(221, 98);
            this.tbCurrentStat.Name = "tbCurrentStat";
            this.tbCurrentStat.ReadOnly = true;
            this.tbCurrentStat.Size = new System.Drawing.Size(129, 20);
            this.tbCurrentStat.TabIndex = 5;
            // 
            // tbStatDate
            // 
            this.tbStatDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatDate.Location = new System.Drawing.Point(221, 67);
            this.tbStatDate.Name = "tbStatDate";
            this.tbStatDate.ReadOnly = true;
            this.tbStatDate.Size = new System.Drawing.Size(129, 20);
            this.tbStatDate.TabIndex = 4;
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrderDate.Location = new System.Drawing.Point(221, 34);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.ReadOnly = true;
            this.tbOrderDate.Size = new System.Drawing.Size(129, 20);
            this.tbOrderDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текущий статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата последнего изменения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заказа";
            // 
            // goBackToFilterButton
            // 
            this.goBackToFilterButton.Location = new System.Drawing.Point(587, 309);
            this.goBackToFilterButton.Name = "goBackToFilterButton";
            this.goBackToFilterButton.Size = new System.Drawing.Size(161, 23);
            this.goBackToFilterButton.TabIndex = 12;
            this.goBackToFilterButton.Text = "Фильтры";
            this.goBackToFilterButton.UseVisualStyleBackColor = true;
            this.goBackToFilterButton.Visible = false;
            this.goBackToFilterButton.Click += new System.EventHandler(this.GoBackToFilterButton_Click);
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 365);
            this.Controls.Add(this.goBackToFilterButton);
            this.Controls.Add(this.changeStatGroup);
            this.Controls.Add(this.orderGroup);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.goBackToMainButton);
            this.Name = "OrderStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderStatus";
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.orderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.changeStatGroup.ResumeLayout(false);
            this.changeStatGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tbChooseCity;
        private System.Windows.Forms.ComboBox tbChooseStat;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Button submitFilterButton;
        private System.Windows.Forms.Button goBackToMainButton;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox orderGroup;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.GroupBox changeStatGroup;
        private System.Windows.Forms.TextBox tbStatDate;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeStatButton;
        private System.Windows.Forms.TextBox tbCurrentStat;
        private System.Windows.Forms.Button goBackToFilterButton;
    }
}