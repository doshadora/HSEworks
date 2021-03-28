namespace courseWork2
{
    partial class MainCust
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
            this.menuList = new System.Windows.Forms.ListBox();
            this.menuBox = new System.Windows.Forms.TextBox();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChooseSubCat = new System.Windows.Forms.ComboBox();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catsubcat_DataSet = new courseWork2.catsubcat_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChooseCat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoryTableAdapter = new courseWork2.catsubcat_DataSetTableAdapters.categoryTableAdapter();
            this.subcategoryTableAdapter = new courseWork2.catsubcat_DataSetTableAdapters.subcategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.productGroup.SuspendLayout();
            this.filterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catsubcat_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.picPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuList
            // 
            this.menuList.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuList.FormattingEnabled = true;
            this.menuList.ItemHeight = 25;
            this.menuList.Items.AddRange(new object[] {
            "😠 Моя корзина",
            "😨 Мои заказы",
            "😭 Мой аккаунт"});
            this.menuList.Location = new System.Drawing.Point(609, 38);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(128, 79);
            this.menuList.TabIndex = 7;
            this.menuList.Visible = false;
            this.menuList.SelectedIndexChanged += new System.EventHandler(this.MenuList_SelectedIndexChanged);
            this.menuList.MouseLeave += new System.EventHandler(this.MenuList_MouseLeave);
            // 
            // menuBox
            // 
            this.menuBox.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBox.Location = new System.Drawing.Point(609, 14);
            this.menuBox.Name = "menuBox";
            this.menuBox.ReadOnly = true;
            this.menuBox.Size = new System.Drawing.Size(128, 32);
            this.menuBox.TabIndex = 8;
            this.menuBox.Text = "        😭Меню😭        ";
            this.menuBox.MouseHover += new System.EventHandler(this.MenuBox_MouseHover);
            // 
            // productPic
            // 
            this.productPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPic.Location = new System.Drawing.Point(3, 16);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(139, 223);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPic.TabIndex = 15;
            this.productPic.TabStop = false;
            // 
            // productGroup
            // 
            this.productGroup.Controls.Add(this.productLabel);
            this.productGroup.Controls.Add(this.productPic);
            this.productGroup.Location = new System.Drawing.Point(823, 47);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(145, 242);
            this.productGroup.TabIndex = 16;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "productGroup";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productLabel.Location = new System.Drawing.Point(3, 226);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(69, 13);
            this.productLabel.TabIndex = 16;
            this.productLabel.Text = "productLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(16, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 29);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Каталог товаров";
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.applyFilterButton);
            this.filterGroup.Controls.Add(this.label2);
            this.filterGroup.Controls.Add(this.tbChooseSubCat);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Controls.Add(this.tbChooseCat);
            this.filterGroup.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGroup.Location = new System.Drawing.Point(5, 47);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(139, 174);
            this.filterGroup.TabIndex = 19;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Фильтры";
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFilterButton.Location = new System.Drawing.Point(6, 136);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(124, 23);
            this.applyFilterButton.TabIndex = 8;
            this.applyFilterButton.Text = "button1";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подкатегория";
            // 
            // tbChooseSubCat
            // 
            this.tbChooseSubCat.DataSource = this.subcategoryBindingSource;
            this.tbChooseSubCat.DisplayMember = "subcategory_name";
            this.tbChooseSubCat.Enabled = false;
            this.tbChooseSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChooseSubCat.FormattingEnabled = true;
            this.tbChooseSubCat.Location = new System.Drawing.Point(6, 100);
            this.tbChooseSubCat.Name = "tbChooseSubCat";
            this.tbChooseSubCat.Size = new System.Drawing.Size(123, 21);
            this.tbChooseSubCat.TabIndex = 2;
            this.tbChooseSubCat.ValueMember = "subcategory_id";
            this.tbChooseSubCat.SelectionChangeCommitted += new System.EventHandler(this.TbChooseSubCat_SelectionChangeCommitted);
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataMember = "subcategory";
            this.subcategoryBindingSource.DataSource = this.catsubcat_DataSet;
            // 
            // catsubcat_DataSet
            // 
            this.catsubcat_DataSet.DataSetName = "catsubcat_DataSet";
            this.catsubcat_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория";
            // 
            // tbChooseCat
            // 
            this.tbChooseCat.DataSource = this.categoryBindingSource;
            this.tbChooseCat.DisplayMember = "category_name";
            this.tbChooseCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChooseCat.FormattingEnabled = true;
            this.tbChooseCat.Location = new System.Drawing.Point(7, 48);
            this.tbChooseCat.Name = "tbChooseCat";
            this.tbChooseCat.Size = new System.Drawing.Size(123, 21);
            this.tbChooseCat.TabIndex = 0;
            this.tbChooseCat.ValueMember = "category_id";
            this.tbChooseCat.SelectionChangeCommitted += new System.EventHandler(this.TbChooseCat_SelectionChangeCommitted);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.catsubcat_DataSet;
            // 
            // picPanel
            // 
            this.picPanel.AutoScroll = true;
            this.picPanel.Controls.Add(this.label5);
            this.picPanel.Controls.Add(this.pictureBox1);
            this.picPanel.Location = new System.Drawing.Point(161, 52);
            this.picPanel.MaximumSize = new System.Drawing.Size(588, 391);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(588, 378);
            this.picPanel.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // subcategoryTableAdapter
            // 
            this.subcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // MainCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 411);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.picPanel);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productGroup);
            this.Controls.Add(this.menuBox);
            this.Name = "MainCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainCust";
            this.Load += new System.EventHandler(this.MainCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.productGroup.ResumeLayout(false);
            this.productGroup.PerformLayout();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catsubcat_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.picPanel.ResumeLayout(false);
            this.picPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox menuList;
        private System.Windows.Forms.TextBox menuBox;
        private System.Windows.Forms.PictureBox productPic;
        private System.Windows.Forms.GroupBox productGroup;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.ComboBox tbChooseCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbChooseSubCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private catsubcat_DataSet catsubcat_DataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private catsubcat_DataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private catsubcat_DataSetTableAdapters.subcategoryTableAdapter subcategoryTableAdapter;
        private System.Windows.Forms.Button applyFilterButton;
    }
}