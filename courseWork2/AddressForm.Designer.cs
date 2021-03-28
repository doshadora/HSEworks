namespace courseWork2
{
    partial class AddressForm
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
            this.Col1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothes_storeDataSet2 = new courseWork2.clothes_storeDataSet2();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothes_storeDataSet = new courseWork2.clothes_storeDataSet();
            this.get_AddressTableAdapter = new courseWork2.clothes_storeDataSetTableAdapters.Get_AddressTableAdapter();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.backToMainShopButton = new System.Windows.Forms.Button();
            this.saveAddressButton = new System.Windows.Forms.Button();
            this.cityTableAdapter = new courseWork2.clothes_storeDataSet2TableAdapters.cityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // storeAddressGrid
            // 
            this.storeAddressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeAddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeAddressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.storeAddressGrid.Location = new System.Drawing.Point(12, 37);
            this.storeAddressGrid.Name = "storeAddressGrid";
            this.storeAddressGrid.Size = new System.Drawing.Size(386, 188);
            this.storeAddressGrid.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col1.DataSource = this.cityBindingSource;
            this.Col1.DisplayMember = "city_name";
            this.Col1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Col1.DisplayStyleForCurrentCellOnly = true;
            this.Col1.HeaderText = "Город";
            this.Col1.MaxDropDownItems = 100;
            this.Col1.Name = "Col1";
            this.Col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col1.ToolTipText = "Поиск по первой букве";
            this.Col1.ValueMember = "city_name";
            this.Col1.Width = 150;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.clothes_storeDataSet2;
            // 
            // clothes_storeDataSet2
            // 
            this.clothes_storeDataSet2.DataSetName = "clothes_storeDataSet2";
            this.clothes_storeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Col2
            // 
            this.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col2.HeaderText = "Адрес";
            this.Col2.Name = "Col2";
            // 
            // getAddressBindingSource
            // 
            this.getAddressBindingSource.DataMember = "Get_Address";
            this.getAddressBindingSource.DataSource = this.clothes_storeDataSet;
            // 
            // clothes_storeDataSet
            // 
            this.clothes_storeDataSet.DataSetName = "clothes_storeDataSet";
            this.clothes_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_AddressTableAdapter
            // 
            this.get_AddressTableAdapter.ClearBeforeFill = true;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeNameLabel.Location = new System.Drawing.Point(9, 9);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(85, 16);
            this.storeNameLabel.TabIndex = 1;
            this.storeNameLabel.Text = "storeName";
            // 
            // backToMainShopButton
            // 
            this.backToMainShopButton.Location = new System.Drawing.Point(224, 233);
            this.backToMainShopButton.Name = "backToMainShopButton";
            this.backToMainShopButton.Size = new System.Drawing.Size(174, 23);
            this.backToMainShopButton.TabIndex = 2;
            this.backToMainShopButton.Text = "Вернуться к редактированию";
            this.backToMainShopButton.UseVisualStyleBackColor = true;
            this.backToMainShopButton.Click += new System.EventHandler(this.BackToMainShopButton_Click);
            // 
            // saveAddressButton
            // 
            this.saveAddressButton.Location = new System.Drawing.Point(12, 233);
            this.saveAddressButton.Name = "saveAddressButton";
            this.saveAddressButton.Size = new System.Drawing.Size(184, 23);
            this.saveAddressButton.TabIndex = 3;
            this.saveAddressButton.Text = "Сохранить изменения";
            this.saveAddressButton.UseVisualStyleBackColor = true;
            this.saveAddressButton.Click += new System.EventHandler(this.SaveAddressButton_Click);
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this.saveAddressButton);
            this.Controls.Add(this.backToMainShopButton);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.storeAddressGrid);
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адреса магазина";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storeAddressGrid;
        private System.Windows.Forms.BindingSource getAddressBindingSource;
        private clothes_storeDataSet clothes_storeDataSet;
        private clothes_storeDataSetTableAdapters.Get_AddressTableAdapter get_AddressTableAdapter;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Button backToMainShopButton;
        private System.Windows.Forms.Button saveAddressButton;
        private clothes_storeDataSet2 clothes_storeDataSet2;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private clothes_storeDataSet2TableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
    }
}