namespace courseWork2
{
    partial class Catalogue
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
            this.labelCat = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewProdButton = new System.Windows.Forms.Button();
            this.fullInfoProdButton = new System.Windows.Forms.Button();
            this.tbChooseCode = new System.Windows.Forms.TextBox();
            this.tbChooseName = new System.Windows.Forms.TextBox();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addToStoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(13, 9);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(63, 27);
            this.labelCat.TabIndex = 0;
            this.labelCat.Text = "labelCat";
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AllowUserToResizeColumns = false;
            this.productGrid.AllowUserToResizeRows = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeCol,
            this.nameCol});
            this.productGrid.Location = new System.Drawing.Point(12, 119);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productGrid.RowHeadersVisible = false;
            this.productGrid.ShowEditingIcon = false;
            this.productGrid.Size = new System.Drawing.Size(465, 151);
            this.productGrid.TabIndex = 1;
            this.productGrid.Leave += new System.EventHandler(this.ProductGrid_Leave);
            this.productGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductGrid_MouseClick);
            // 
            // codeCol
            // 
            this.codeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codeCol.HeaderText = "Артикул";
            this.codeCol.Name = "codeCol";
            this.codeCol.ReadOnly = true;
            this.codeCol.Width = 73;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCol.HeaderText = "Название товара";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // addNewProdButton
            // 
            this.addNewProdButton.Location = new System.Drawing.Point(12, 70);
            this.addNewProdButton.Name = "addNewProdButton";
            this.addNewProdButton.Size = new System.Drawing.Size(134, 43);
            this.addNewProdButton.TabIndex = 2;
            this.addNewProdButton.Text = "Создать товар";
            this.addNewProdButton.UseVisualStyleBackColor = true;
            this.addNewProdButton.Click += new System.EventHandler(this.AddNewProdButton_Click);
            // 
            // fullInfoProdButton
            // 
            this.fullInfoProdButton.Enabled = false;
            this.fullInfoProdButton.Location = new System.Drawing.Point(152, 70);
            this.fullInfoProdButton.Name = "fullInfoProdButton";
            this.fullInfoProdButton.Size = new System.Drawing.Size(134, 20);
            this.fullInfoProdButton.TabIndex = 3;
            this.fullInfoProdButton.Text = "fullInfoProdButton";
            this.fullInfoProdButton.UseVisualStyleBackColor = true;
            this.fullInfoProdButton.Click += new System.EventHandler(this.FullInfoProdButton_Click);
            // 
            // tbChooseCode
            // 
            this.tbChooseCode.Location = new System.Drawing.Point(354, 18);
            this.tbChooseCode.MaxLength = 10;
            this.tbChooseCode.Name = "tbChooseCode";
            this.tbChooseCode.Size = new System.Drawing.Size(122, 20);
            this.tbChooseCode.TabIndex = 4;
            this.tbChooseCode.Text = "Артикул";
            this.tbChooseCode.Enter += new System.EventHandler(this.TbChooseCode_Enter);
            this.tbChooseCode.Leave += new System.EventHandler(this.TbChooseCode_Leave);
            // 
            // tbChooseName
            // 
            this.tbChooseName.Location = new System.Drawing.Point(354, 44);
            this.tbChooseName.Name = "tbChooseName";
            this.tbChooseName.Size = new System.Drawing.Size(122, 20);
            this.tbChooseName.TabIndex = 5;
            this.tbChooseName.Text = "Название товара";
            this.tbChooseName.Enter += new System.EventHandler(this.TbChooseName_Enter);
            this.tbChooseName.Leave += new System.EventHandler(this.TbChooseName_Leave);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Enabled = false;
            this.applyFilterButton.Location = new System.Drawing.Point(354, 70);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(123, 43);
            this.applyFilterButton.TabIndex = 6;
            this.applyFilterButton.Text = "Применить фильтр";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Location = new System.Drawing.Point(12, 277);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(465, 23);
            this.goBackToMainButton.TabIndex = 8;
            this.goBackToMainButton.Text = "Вернуться в главное меню";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
            this.goBackToMainButton.Click += new System.EventHandler(this.GoBackToMainButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(292, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "↺";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addToStoreButton
            // 
            this.addToStoreButton.Enabled = false;
            this.addToStoreButton.Location = new System.Drawing.Point(152, 93);
            this.addToStoreButton.Name = "addToStoreButton";
            this.addToStoreButton.Size = new System.Drawing.Size(134, 20);
            this.addToStoreButton.TabIndex = 10;
            this.addToStoreButton.Text = "Добавить в магазин";
            this.addToStoreButton.UseVisualStyleBackColor = true;
            this.addToStoreButton.Click += new System.EventHandler(this.AddToStoreButton_Click);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 312);
            this.Controls.Add(this.addToStoreButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goBackToMainButton);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.tbChooseName);
            this.Controls.Add(this.tbChooseCode);
            this.Controls.Add(this.fullInfoProdButton);
            this.Controls.Add(this.addNewProdButton);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.labelCat);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Button addNewProdButton;
        private System.Windows.Forms.Button fullInfoProdButton;
        private System.Windows.Forms.TextBox tbChooseCode;
        private System.Windows.Forms.TextBox tbChooseName;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button goBackToMainButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addToStoreButton;
    }
}