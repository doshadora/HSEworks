namespace courseWork2
{
    partial class AddProductToStore
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
            this.storeAddressGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothes_storeDataSet = new courseWork2.clothes_storeDataSet();
            this.clothesstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.ComboBox();
            this.sizetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToStore_DataSet = new courseWork2.AddToStore_DataSet();
            this.tbSize = new System.Windows.Forms.ComboBox();
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentAmount = new System.Windows.Forms.TextBox();
            this.tbNewAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            this.size_typeTableAdapter = new courseWork2.AddToStore_DataSetTableAdapters.size_typeTableAdapter();
            this.sizeTableAdapter = new courseWork2.AddToStore_DataSetTableAdapters.sizeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToStore_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // storeAddressGrid
            // 
            this.storeAddressGrid.AllowUserToAddRows = false;
            this.storeAddressGrid.AllowUserToDeleteRows = false;
            this.storeAddressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeAddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeAddressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.storeAddressGrid.Location = new System.Drawing.Point(189, 37);
            this.storeAddressGrid.Name = "storeAddressGrid";
            this.storeAddressGrid.ReadOnly = true;
            this.storeAddressGrid.RowHeadersVisible = false;
            this.storeAddressGrid.Size = new System.Drawing.Size(339, 155);
            this.storeAddressGrid.TabIndex = 1;
            this.storeAddressGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StoreAddressGrid_MouseClick);
            // 
            // Col1
            // 
            this.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col1.HeaderText = "Город";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col1.Width = 43;
            // 
            // Col2
            // 
            this.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col2.FillWeight = 21.2766F;
            this.Col2.HeaderText = "Адрес";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // clothes_storeDataSet
            // 
            this.clothes_storeDataSet.DataSetName = "clothes_storeDataSet";
            this.clothes_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothesstoreDataSetBindingSource
            // 
            this.clothesstoreDataSetBindingSource.DataSource = this.clothes_storeDataSet;
            this.clothesstoreDataSetBindingSource.Position = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(108, 27);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Добавление ";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(13, 37);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(161, 20);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.Text = "Выберите адрес";
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCountry
            // 
            this.tbCountry.DataSource = this.sizetypeBindingSource;
            this.tbCountry.DisplayMember = "country_name";
            this.tbCountry.Enabled = false;
            this.tbCountry.FormattingEnabled = true;
            this.tbCountry.Location = new System.Drawing.Point(12, 82);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(79, 21);
            this.tbCountry.TabIndex = 4;
            this.tbCountry.ValueMember = "size_country_id";
            this.tbCountry.Visible = false;
            this.tbCountry.SelectedValueChanged += new System.EventHandler(this.TbCountry_SelectedValueChanged);
            // 
            // sizetypeBindingSource
            // 
            this.sizetypeBindingSource.DataMember = "size_type";
            this.sizetypeBindingSource.DataSource = this.addToStoreDataSetBindingSource;
            // 
            // addToStoreDataSetBindingSource
            // 
            this.addToStoreDataSetBindingSource.DataSource = this.addToStore_DataSet;
            this.addToStoreDataSetBindingSource.Position = 0;
            // 
            // addToStore_DataSet
            // 
            this.addToStore_DataSet.DataSetName = "AddToStore_DataSet";
            this.addToStore_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSize
            // 
            this.tbSize.DataSource = this.sizeBindingSource;
            this.tbSize.DisplayMember = "size_value";
            this.tbSize.Enabled = false;
            this.tbSize.FormattingEnabled = true;
            this.tbSize.Location = new System.Drawing.Point(95, 82);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(79, 21);
            this.tbSize.TabIndex = 5;
            this.tbSize.ValueMember = "size_id";
            this.tbSize.Visible = false;
            this.tbSize.SelectionChangeCommitted += new System.EventHandler(this.TbSize_SelectionChangeCommitted);
            // 
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataMember = "size";
            this.sizeBindingSource.DataSource = this.addToStoreDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Страна";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размер";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текущее кол-во в наличии";
            this.label4.Visible = false;
            // 
            // tbCurrentAmount
            // 
            this.tbCurrentAmount.Location = new System.Drawing.Point(13, 128);
            this.tbCurrentAmount.Name = "tbCurrentAmount";
            this.tbCurrentAmount.ReadOnly = true;
            this.tbCurrentAmount.Size = new System.Drawing.Size(161, 20);
            this.tbCurrentAmount.TabIndex = 9;
            this.tbCurrentAmount.Visible = false;
            // 
            // tbNewAmount
            // 
            this.tbNewAmount.Enabled = false;
            this.tbNewAmount.Location = new System.Drawing.Point(12, 172);
            this.tbNewAmount.Name = "tbNewAmount";
            this.tbNewAmount.Size = new System.Drawing.Size(161, 20);
            this.tbNewAmount.TabIndex = 11;
            this.tbNewAmount.Visible = false;
            this.tbNewAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNewAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Новое количество";
            this.label5.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 198);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить количество";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Location = new System.Drawing.Point(189, 198);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(339, 23);
            this.goBackToMainButton.TabIndex = 13;
            this.goBackToMainButton.Text = "Вернуться в каталог";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
            this.goBackToMainButton.Click += new System.EventHandler(this.GoBackToMainButton_Click);
            // 
            // size_typeTableAdapter
            // 
            this.size_typeTableAdapter.ClearBeforeFill = true;
            // 
            // sizeTableAdapter
            // 
            this.sizeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(502, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "✅";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddProductToStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goBackToMainButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tbNewAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCurrentAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.storeAddressGrid);
            this.Name = "AddProductToStore";
            this.Text = "AddProductToStore";
            this.Load += new System.EventHandler(this.AddProductToStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToStore_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storeAddressGrid;
        private System.Windows.Forms.BindingSource clothesstoreDataSetBindingSource;
        private clothes_storeDataSet clothes_storeDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox tbCountry;
        private System.Windows.Forms.ComboBox tbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentAmount;
        private System.Windows.Forms.TextBox tbNewAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button goBackToMainButton;
        private System.Windows.Forms.BindingSource addToStoreDataSetBindingSource;
        private AddToStore_DataSet addToStore_DataSet;
        private System.Windows.Forms.BindingSource sizetypeBindingSource;
        private AddToStore_DataSetTableAdapters.size_typeTableAdapter size_typeTableAdapter;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private AddToStore_DataSetTableAdapters.sizeTableAdapter sizeTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}