namespace courseWork2
{
    partial class CustOrder
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
            this.tbChooseAddress = new System.Windows.Forms.ComboBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custOrder_DataSet = new courseWork2.custOrder_DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChooseSize = new System.Windows.Forms.ComboBox();
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custOrder_DataSet1 = new courseWork2.custOrder_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPreview = new System.Windows.Forms.PictureBox();
            this.prodPic = new System.Windows.Forms.PictureBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChooseCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cityTableAdapter = new courseWork2.custOrder_DataSetTableAdapters.cityTableAdapter();
            this.addressTableAdapter = new courseWork2.custOrder_DataSetTableAdapters.addressTableAdapter();
            this.sizeTableAdapter = new courseWork2.custOrder_DataSetTableAdapters.sizeTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbChooseAddress
            // 
            this.tbChooseAddress.DataSource = this.addressBindingSource;
            this.tbChooseAddress.DisplayMember = "address_street";
            this.tbChooseAddress.Enabled = false;
            this.tbChooseAddress.FormattingEnabled = true;
            this.tbChooseAddress.Location = new System.Drawing.Point(250, 65);
            this.tbChooseAddress.Name = "tbChooseAddress";
            this.tbChooseAddress.Size = new System.Drawing.Size(163, 21);
            this.tbChooseAddress.TabIndex = 37;
            this.tbChooseAddress.ValueMember = "address_id";
            this.tbChooseAddress.SelectionChangeCommitted += new System.EventHandler(this.TbChooseAddress_SelectionChangeCommitted);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.custOrder_DataSet;
            // 
            // custOrder_DataSet
            // 
            this.custOrder_DataSet.DataSetName = "custOrder_DataSet";
            this.custOrder_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Адрес";
            // 
            // upDownAmount
            // 
            this.upDownAmount.Enabled = false;
            this.upDownAmount.Location = new System.Drawing.Point(375, 92);
            this.upDownAmount.Name = "upDownAmount";
            this.upDownAmount.Size = new System.Drawing.Size(38, 20);
            this.upDownAmount.TabIndex = 35;
            this.upDownAmount.ValueChanged += new System.EventHandler(this.UpDownAmount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Размер";
            // 
            // tbChooseSize
            // 
            this.tbChooseSize.DataSource = this.sizeBindingSource;
            this.tbChooseSize.DisplayMember = "size_value";
            this.tbChooseSize.Enabled = false;
            this.tbChooseSize.FormattingEnabled = true;
            this.tbChooseSize.Location = new System.Drawing.Point(250, 92);
            this.tbChooseSize.Name = "tbChooseSize";
            this.tbChooseSize.Size = new System.Drawing.Size(119, 21);
            this.tbChooseSize.TabIndex = 33;
            this.tbChooseSize.ValueMember = "size_id";
            this.tbChooseSize.SelectionChangeCommitted += new System.EventHandler(this.TbChooseSize_SelectionChangeCommitted);
            // 
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataMember = "size";
            this.sizeBindingSource.DataSource = this.custOrder_DataSet1;
            // 
            // custOrder_DataSet1
            // 
            this.custOrder_DataSet1.DataSetName = "custOrder_DataSet";
            this.custOrder_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            // 
            // logoPreview
            // 
            this.logoPreview.Location = new System.Drawing.Point(12, 39);
            this.logoPreview.Name = "logoPreview";
            this.logoPreview.Size = new System.Drawing.Size(150, 90);
            this.logoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPreview.TabIndex = 38;
            this.logoPreview.TabStop = false;
            // 
            // prodPic
            // 
            this.prodPic.Location = new System.Drawing.Point(432, 9);
            this.prodPic.Name = "prodPic";
            this.prodPic.Size = new System.Drawing.Size(83, 120);
            this.prodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodPic.TabIndex = 40;
            this.prodPic.TabStop = false;
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(12, 141);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(248, 23);
            this.orderButton.TabIndex = 41;
            this.orderButton.Text = "Заказать товар";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Вернуться к корзине";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "label4";
            // 
            // tbChooseCity
            // 
            this.tbChooseCity.DataSource = this.cityBindingSource;
            this.tbChooseCity.DisplayMember = "city_name";
            this.tbChooseCity.FormattingEnabled = true;
            this.tbChooseCity.Location = new System.Drawing.Point(250, 39);
            this.tbChooseCity.Name = "tbChooseCity";
            this.tbChooseCity.Size = new System.Drawing.Size(163, 21);
            this.tbChooseCity.TabIndex = 45;
            this.tbChooseCity.ValueMember = "city_id";
            this.tbChooseCity.SelectionChangeCommitted += new System.EventHandler(this.TbChooseCity_SelectionChangeCommitted);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.custOrder_DataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Город";
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // sizeTableAdapter
            // 
            this.sizeTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(179, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // CustOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 184);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbChooseCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.prodPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPreview);
            this.Controls.Add(this.tbChooseAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upDownAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbChooseSize);
            this.Name = "CustOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustOrder";
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbChooseAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDownAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbChooseSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPreview;
        private System.Windows.Forms.PictureBox prodPic;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbChooseCity;
        private System.Windows.Forms.Label label5;
        private custOrder_DataSet custOrder_DataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private custOrder_DataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private custOrder_DataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private custOrder_DataSet custOrder_DataSet1;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private custOrder_DataSetTableAdapters.sizeTableAdapter sizeTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}