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
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.backToMainShopButton = new System.Windows.Forms.Button();
            this.saveAddressButton = new System.Windows.Forms.Button();
            this.csDataSet = new courseWork2.csDataSet();
            this.get_AddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_AddressTableAdapter = new courseWork2.csDataSetTableAdapters.Get_AddressTableAdapter();
            this.tableAdapterManager = new courseWork2.csDataSetTableAdapters.TableAdapterManager();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressstreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_AddressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // storeAddressGrid
            // 
            this.storeAddressGrid.AutoGenerateColumns = false;
            this.storeAddressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeAddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeAddressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citynameDataGridViewTextBoxColumn,
            this.addressstreetDataGridViewTextBoxColumn});
            this.storeAddressGrid.DataSource = this.get_AddressBindingSource;
            this.storeAddressGrid.Location = new System.Drawing.Point(12, 37);
            this.storeAddressGrid.Name = "storeAddressGrid";
            this.storeAddressGrid.Size = new System.Drawing.Size(386, 188);
            this.storeAddressGrid.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeNameLabel.Location = new System.Drawing.Point(9, 9);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(84, 16);
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
            // csDataSet
            // 
            this.csDataSet.DataSetName = "csDataSet";
            this.csDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_AddressBindingSource
            // 
            this.get_AddressBindingSource.DataMember = "Get_Address";
            this.get_AddressBindingSource.DataSource = this.csDataSet;
            // 
            // get_AddressTableAdapter
            // 
            this.get_AddressTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cat_subcategoryTableAdapter = null;
            this.tableAdapterManager.category_genderTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.cheque_product_statusTableAdapter = null;
            this.tableAdapterManager.cheque_setTableAdapter = null;
            this.tableAdapterManager.chequeTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.priceTableAdapter = null;
            this.tableAdapterManager.product_addressTableAdapter = null;
            this.tableAdapterManager.product_sizeTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.size_typeTableAdapter = null;
            this.tableAdapterManager.sizeTableAdapter = null;
            this.tableAdapterManager.status_of_chequeTableAdapter = null;
            this.tableAdapterManager.store_addressTableAdapter = null;
            this.tableAdapterManager.storeTableAdapter = null;
            this.tableAdapterManager.subcategoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = courseWork2.csDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "Город";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            // 
            // addressstreetDataGridViewTextBoxColumn
            // 
            this.addressstreetDataGridViewTextBoxColumn.DataPropertyName = "address_street";
            this.addressstreetDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressstreetDataGridViewTextBoxColumn.Name = "addressstreetDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.storeAddressGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_AddressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storeAddressGrid;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Button backToMainShopButton;
        private System.Windows.Forms.Button saveAddressButton;
        private csDataSet csDataSet;
        private System.Windows.Forms.BindingSource get_AddressBindingSource;
        private csDataSetTableAdapters.Get_AddressTableAdapter get_AddressTableAdapter;
        private csDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressstreetDataGridViewTextBoxColumn;
    }
}