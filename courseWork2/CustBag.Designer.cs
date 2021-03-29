namespace courseWork2
{
    partial class CustBag
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
            this.bagGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bagGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bagGrid
            // 
            this.bagGrid.AllowUserToAddRows = false;
            this.bagGrid.AllowUserToDeleteRows = false;
            this.bagGrid.AllowUserToResizeColumns = false;
            this.bagGrid.AllowUserToResizeRows = false;
            this.bagGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.bagGrid.Location = new System.Drawing.Point(12, 40);
            this.bagGrid.Name = "bagGrid";
            this.bagGrid.ReadOnly = true;
            this.bagGrid.RowHeadersVisible = false;
            this.bagGrid.Size = new System.Drawing.Size(546, 272);
            this.bagGrid.TabIndex = 0;
            this.bagGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BagGrid_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Наименование товара";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Магазин";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Корзина товаров";
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(12, 318);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(270, 23);
            this.makeOrderButton.TabIndex = 2;
            this.makeOrderButton.Text = "Заказать товар";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.MakeOrderButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вернуться к каталогу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CustBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bagGrid);
            this.Name = "CustBag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustBag";
            ((System.ComponentModel.ISupportInitialize)(this.bagGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bagGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}