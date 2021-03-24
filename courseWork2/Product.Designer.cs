namespace courseWork2
{
    partial class Product
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
            this.labelProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProdCode = new System.Windows.Forms.TextBox();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbProdInfo = new System.Windows.Forms.RichTextBox();
            this.tbProdCat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catDataSet = new courseWork2.catDataSet();
            this.tbProdSubCat = new System.Windows.Forms.ComboBox();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCatDataSet = new courseWork2.subCatDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.prodPhotoButton = new System.Windows.Forms.Button();
            this.prodSaveButton = new System.Windows.Forms.Button();
            this.goBackToMainButton = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.tbGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderDataSet = new courseWork2.genderDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.genderTableAdapter = new courseWork2.genderDataSetTableAdapters.genderTableAdapter();
            this.categoryTableAdapter = new courseWork2.catDataSetTableAdapters.categoryTableAdapter();
            this.subcategoryTableAdapter = new courseWork2.subCatDataSetTableAdapters.subcategoryTableAdapter();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(17, 9);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(76, 29);
            this.labelProd.TabIndex = 0;
            this.labelProd.Text = "labelProd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категория";
            // 
            // tbProdCode
            // 
            this.tbProdCode.Location = new System.Drawing.Point(145, 54);
            this.tbProdCode.MaxLength = 10;
            this.tbProdCode.Name = "tbProdCode";
            this.tbProdCode.Size = new System.Drawing.Size(160, 20);
            this.tbProdCode.TabIndex = 5;
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(145, 79);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(160, 20);
            this.tbProdName.TabIndex = 6;
            // 
            // tbProdInfo
            // 
            this.tbProdInfo.Location = new System.Drawing.Point(145, 105);
            this.tbProdInfo.Name = "tbProdInfo";
            this.tbProdInfo.Size = new System.Drawing.Size(160, 35);
            this.tbProdInfo.TabIndex = 7;
            this.tbProdInfo.Text = "";
            // 
            // tbProdCat
            // 
            this.tbProdCat.DataSource = this.categoryBindingSource;
            this.tbProdCat.DisplayMember = "category_name";
            this.tbProdCat.FormattingEnabled = true;
            this.tbProdCat.Location = new System.Drawing.Point(145, 201);
            this.tbProdCat.Name = "tbProdCat";
            this.tbProdCat.Size = new System.Drawing.Size(160, 21);
            this.tbProdCat.TabIndex = 8;
            this.tbProdCat.ValueMember = "category_id";
            this.tbProdCat.SelectedIndexChanged += new System.EventHandler(this.TbProdCat_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.catDataSet;
            // 
            // catDataSet
            // 
            this.catDataSet.DataSetName = "catDataSet";
            this.catDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdSubCat
            // 
            this.tbProdSubCat.DataSource = this.subcategoryBindingSource;
            this.tbProdSubCat.DisplayMember = "subcategory_name";
            this.tbProdSubCat.Enabled = false;
            this.tbProdSubCat.FormattingEnabled = true;
            this.tbProdSubCat.Location = new System.Drawing.Point(145, 228);
            this.tbProdSubCat.Name = "tbProdSubCat";
            this.tbProdSubCat.Size = new System.Drawing.Size(160, 21);
            this.tbProdSubCat.TabIndex = 10;
            this.tbProdSubCat.ValueMember = "subcategory_id";
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataMember = "subcategory";
            this.subcategoryBindingSource.DataSource = this.subCatDataSet;
            // 
            // subCatDataSet
            // 
            this.subCatDataSet.DataSetName = "subCatDataSet";
            this.subCatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подкатегория";
            // 
            // prodPhotoButton
            // 
            this.prodPhotoButton.Location = new System.Drawing.Point(97, 259);
            this.prodPhotoButton.Name = "prodPhotoButton";
            this.prodPhotoButton.Size = new System.Drawing.Size(283, 23);
            this.prodPhotoButton.TabIndex = 11;
            this.prodPhotoButton.Text = "Добавить фотографию";
            this.prodPhotoButton.UseVisualStyleBackColor = true;
            this.prodPhotoButton.Click += new System.EventHandler(this.ProdPhotoButton_Click);
            // 
            // prodSaveButton
            // 
            this.prodSaveButton.Location = new System.Drawing.Point(97, 288);
            this.prodSaveButton.Name = "prodSaveButton";
            this.prodSaveButton.Size = new System.Drawing.Size(137, 30);
            this.prodSaveButton.TabIndex = 12;
            this.prodSaveButton.Text = "Сохранить изменения";
            this.prodSaveButton.UseVisualStyleBackColor = true;
            this.prodSaveButton.Click += new System.EventHandler(this.ProdSaveButton_Click);
            // 
            // goBackToMainButton
            // 
            this.goBackToMainButton.Location = new System.Drawing.Point(243, 288);
            this.goBackToMainButton.Name = "goBackToMainButton";
            this.goBackToMainButton.Size = new System.Drawing.Size(137, 30);
            this.goBackToMainButton.TabIndex = 13;
            this.goBackToMainButton.Text = "Вернуться в каталог";
            this.goBackToMainButton.UseVisualStyleBackColor = true;
            this.goBackToMainButton.Click += new System.EventHandler(this.GoBackToMainButton_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(325, 54);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(135, 195);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 14;
            this.picPreview.TabStop = false;
            // 
            // tbGender
            // 
            this.tbGender.DataSource = this.genderBindingSource;
            this.tbGender.DisplayMember = "gender_name";
            this.tbGender.FormattingEnabled = true;
            this.tbGender.Location = new System.Drawing.Point(145, 174);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(160, 21);
            this.tbGender.TabIndex = 16;
            this.tbGender.ValueMember = "gender_id";
            this.tbGender.SelectedIndexChanged += new System.EventHandler(this.TbGender_SelectedIndexChanged);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "gender";
            this.genderBindingSource.DataSource = this.genderDataSet;
            // 
            // genderDataSet
            // 
            this.genderDataSet.DataSetName = "genderDataSet";
            this.genderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пол";
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // subcategoryTableAdapter
            // 
            this.subcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(145, 146);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(160, 20);
            this.tbPrice.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Цена";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.goBackToMainButton);
            this.Controls.Add(this.prodSaveButton);
            this.Controls.Add(this.prodPhotoButton);
            this.Controls.Add(this.tbProdSubCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProdCat);
            this.Controls.Add(this.tbProdInfo);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.tbProdCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProd);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProdCode;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.RichTextBox tbProdInfo;
        private System.Windows.Forms.ComboBox tbProdCat;
        private System.Windows.Forms.ComboBox tbProdSubCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button prodPhotoButton;
        private System.Windows.Forms.Button prodSaveButton;
        private System.Windows.Forms.Button goBackToMainButton;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ComboBox tbGender;
        private System.Windows.Forms.Label label6;
        private genderDataSet genderDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private genderDataSetTableAdapters.genderTableAdapter genderTableAdapter;
        private catDataSet catDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private catDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private subCatDataSet subCatDataSet;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private subCatDataSetTableAdapters.subcategoryTableAdapter subcategoryTableAdapter;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
    }
}