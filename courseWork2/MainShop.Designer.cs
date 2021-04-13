namespace courseWork2
{
    partial class MainShop
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
            this.ordersButton = new System.Windows.Forms.Button();
            this.mainPicStore = new System.Windows.Forms.PictureBox();
            this.catalogueButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.editStoreButton = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.goToProfileEditButton = new System.Windows.Forms.Button();
            this.editAccountGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openAddressButton = new System.Windows.Forms.Button();
            this.deleteLogoPreviewButton = new System.Windows.Forms.Button();
            this.saveAccChangesButton = new System.Windows.Forms.Button();
            this.logoPreviewLabel = new System.Windows.Forms.Label();
            this.logoPreview = new System.Windows.Forms.PictureBox();
            this.uploadLogoButton = new System.Windows.Forms.Button();
            this.tbStoreInfo = new System.Windows.Forms.RichTextBox();
            this.tbStoreName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editLogGroup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbEditPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goToLogEditButton = new System.Windows.Forms.Button();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothes_storeDataSet1 = new courseWork2.clothes_storeDataSet1();
            this.getAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothes_storeDataSet = new courseWork2.clothes_storeDataSet();
            this.get_AddressTableAdapter = new courseWork2.clothes_storeDataSetTableAdapters.Get_AddressTableAdapter();
            this.ordersStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersStatus_DataSet = new courseWork2.ordersStatus_DataSet();
            this.ordersStatusTableAdapter = new courseWork2.ordersStatus_DataSetTableAdapters.ordersStatusTableAdapter();
            this.cityTableAdapter = new courseWork2.clothes_storeDataSet1TableAdapters.cityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.groupName.SuspendLayout();
            this.editAccountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).BeginInit();
            this.editLogGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersStatus_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersButton
            // 
            this.ordersButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.Location = new System.Drawing.Point(15, 26);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(190, 53);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // mainPicStore
            // 
            this.mainPicStore.Location = new System.Drawing.Point(233, 26);
            this.mainPicStore.Name = "mainPicStore";
            this.mainPicStore.Size = new System.Drawing.Size(463, 293);
            this.mainPicStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicStore.TabIndex = 1;
            this.mainPicStore.TabStop = false;
            // 
            // catalogueButton
            // 
            this.catalogueButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogueButton.Location = new System.Drawing.Point(15, 104);
            this.catalogueButton.Name = "catalogueButton";
            this.catalogueButton.Size = new System.Drawing.Size(190, 53);
            this.catalogueButton.TabIndex = 2;
            this.catalogueButton.Text = "Каталог";
            this.catalogueButton.UseVisualStyleBackColor = true;
            this.catalogueButton.Click += new System.EventHandler(this.CatalogueButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.Location = new System.Drawing.Point(15, 185);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(190, 53);
            this.statsButton.TabIndex = 3;
            this.statsButton.Text = "Статистика по заказам";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // editStoreButton
            // 
            this.editStoreButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStoreButton.Location = new System.Drawing.Point(15, 266);
            this.editStoreButton.Name = "editStoreButton";
            this.editStoreButton.Size = new System.Drawing.Size(190, 53);
            this.editStoreButton.TabIndex = 4;
            this.editStoreButton.Text = "Редактировать аккаунт";
            this.editStoreButton.UseVisualStyleBackColor = true;
            this.editStoreButton.Click += new System.EventHandler(this.EditStoreButton_Click);
            // 
            // labelStore
            // 
            this.labelStore.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(118, 9);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(616, 59);
            this.labelStore.TabIndex = 5;
            this.labelStore.Text = "labelStore";
            this.labelStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backToMainButton
            // 
            this.backToMainButton.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainButton.Location = new System.Drawing.Point(291, 339);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(167, 23);
            this.backToMainButton.TabIndex = 7;
            this.backToMainButton.Text = "Вернуться в главное меню";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Visible = false;
            this.backToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // logoPic
            // 
            this.logoPic.Location = new System.Drawing.Point(12, 9);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(100, 60);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 8;
            this.logoPic.TabStop = false;
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.backToMainButton);
            this.groupName.Controls.Add(this.goToProfileEditButton);
            this.groupName.Controls.Add(this.catalogueButton);
            this.groupName.Controls.Add(this.statsButton);
            this.groupName.Controls.Add(this.editStoreButton);
            this.groupName.Controls.Add(this.editAccountGroup);
            this.groupName.Controls.Add(this.editLogGroup);
            this.groupName.Controls.Add(this.mainPicStore);
            this.groupName.Controls.Add(this.goToLogEditButton);
            this.groupName.Controls.Add(this.ordersButton);
            this.groupName.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupName.Location = new System.Drawing.Point(12, 71);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(722, 368);
            this.groupName.TabIndex = 9;
            this.groupName.TabStop = false;
            this.groupName.Text = "Главное меню";
            // 
            // goToProfileEditButton
            // 
            this.goToProfileEditButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToProfileEditButton.Location = new System.Drawing.Point(15, 26);
            this.goToProfileEditButton.Name = "goToProfileEditButton";
            this.goToProfileEditButton.Size = new System.Drawing.Size(190, 53);
            this.goToProfileEditButton.TabIndex = 11;
            this.goToProfileEditButton.Text = "Данные об аккаунте";
            this.goToProfileEditButton.UseVisualStyleBackColor = true;
            this.goToProfileEditButton.Visible = false;
            this.goToProfileEditButton.Click += new System.EventHandler(this.GoToProfileEditButton_Click);
            // 
            // editAccountGroup
            // 
            this.editAccountGroup.Controls.Add(this.label6);
            this.editAccountGroup.Controls.Add(this.openAddressButton);
            this.editAccountGroup.Controls.Add(this.deleteLogoPreviewButton);
            this.editAccountGroup.Controls.Add(this.saveAccChangesButton);
            this.editAccountGroup.Controls.Add(this.logoPreviewLabel);
            this.editAccountGroup.Controls.Add(this.logoPreview);
            this.editAccountGroup.Controls.Add(this.uploadLogoButton);
            this.editAccountGroup.Controls.Add(this.tbStoreInfo);
            this.editAccountGroup.Controls.Add(this.tbStoreName);
            this.editAccountGroup.Controls.Add(this.label7);
            this.editAccountGroup.Controls.Add(this.label5);
            this.editAccountGroup.Controls.Add(this.label4);
            this.editAccountGroup.Location = new System.Drawing.Point(233, 15);
            this.editAccountGroup.Name = "editAccountGroup";
            this.editAccountGroup.Size = new System.Drawing.Size(468, 304);
            this.editAccountGroup.TabIndex = 13;
            this.editAccountGroup.TabStop = false;
            this.editAccountGroup.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Адреса магазина";
            // 
            // openAddressButton
            // 
            this.openAddressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddressButton.Location = new System.Drawing.Point(224, 59);
            this.openAddressButton.Name = "openAddressButton";
            this.openAddressButton.Size = new System.Drawing.Size(227, 23);
            this.openAddressButton.TabIndex = 20;
            this.openAddressButton.Text = "Просмотреть адреса";
            this.openAddressButton.UseVisualStyleBackColor = true;
            this.openAddressButton.Click += new System.EventHandler(this.OpenAddressButton_Click);
            // 
            // deleteLogoPreviewButton
            // 
            this.deleteLogoPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLogoPreviewButton.Location = new System.Drawing.Point(224, 227);
            this.deleteLogoPreviewButton.Name = "deleteLogoPreviewButton";
            this.deleteLogoPreviewButton.Size = new System.Drawing.Size(108, 27);
            this.deleteLogoPreviewButton.TabIndex = 15;
            this.deleteLogoPreviewButton.Text = "Удалить";
            this.deleteLogoPreviewButton.UseVisualStyleBackColor = true;
            this.deleteLogoPreviewButton.Click += new System.EventHandler(this.DeleteLogoPreviewButton_Click);
            // 
            // saveAccChangesButton
            // 
            this.saveAccChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAccChangesButton.Location = new System.Drawing.Point(158, 273);
            this.saveAccChangesButton.Name = "saveAccChangesButton";
            this.saveAccChangesButton.Size = new System.Drawing.Size(152, 22);
            this.saveAccChangesButton.TabIndex = 14;
            this.saveAccChangesButton.Text = "Сохранить изменения";
            this.saveAccChangesButton.UseVisualStyleBackColor = true;
            this.saveAccChangesButton.Click += new System.EventHandler(this.SaveAccChangesButton_Click);
            // 
            // logoPreviewLabel
            // 
            this.logoPreviewLabel.AutoSize = true;
            this.logoPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoPreviewLabel.Location = new System.Drawing.Point(360, 219);
            this.logoPreviewLabel.Name = "logoPreviewLabel";
            this.logoPreviewLabel.Size = new System.Drawing.Size(82, 13);
            this.logoPreviewLabel.TabIndex = 11;
            this.logoPreviewLabel.Text = "Предпросмотр";
            // 
            // logoPreview
            // 
            this.logoPreview.Location = new System.Drawing.Point(351, 194);
            this.logoPreview.Name = "logoPreview";
            this.logoPreview.Size = new System.Drawing.Size(100, 60);
            this.logoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPreview.TabIndex = 10;
            this.logoPreview.TabStop = false;
            // 
            // uploadLogoButton
            // 
            this.uploadLogoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLogoButton.Location = new System.Drawing.Point(224, 194);
            this.uploadLogoButton.Name = "uploadLogoButton";
            this.uploadLogoButton.Size = new System.Drawing.Size(108, 27);
            this.uploadLogoButton.TabIndex = 7;
            this.uploadLogoButton.Text = "Загрузить";
            this.uploadLogoButton.UseVisualStyleBackColor = true;
            this.uploadLogoButton.Click += new System.EventHandler(this.UploadLogoButton_Click);
            // 
            // tbStoreInfo
            // 
            this.tbStoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoreInfo.Location = new System.Drawing.Point(224, 94);
            this.tbStoreInfo.Name = "tbStoreInfo";
            this.tbStoreInfo.Size = new System.Drawing.Size(227, 81);
            this.tbStoreInfo.TabIndex = 6;
            this.tbStoreInfo.Text = "";
            // 
            // tbStoreName
            // 
            this.tbStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoreName.Location = new System.Drawing.Point(224, 25);
            this.tbStoreName.Name = "tbStoreName";
            this.tbStoreName.Size = new System.Drawing.Size(227, 20);
            this.tbStoreName.TabIndex = 4;
            this.tbStoreName.Click += new System.EventHandler(this.TbStoreName_Click);
            this.tbStoreName.Leave += new System.EventHandler(this.TbStoreName_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Информация о магазине";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Логотип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Название магазина";
            // 
            // editLogGroup
            // 
            this.editLogGroup.Controls.Add(this.button2);
            this.editLogGroup.Controls.Add(this.button1);
            this.editLogGroup.Controls.Add(this.tbNewPassword);
            this.editLogGroup.Controls.Add(this.tbOldPassword);
            this.editLogGroup.Controls.Add(this.tbEditPhone);
            this.editLogGroup.Controls.Add(this.label2);
            this.editLogGroup.Controls.Add(this.label1);
            this.editLogGroup.Controls.Add(this.saveLogButton);
            this.editLogGroup.Controls.Add(this.label3);
            this.editLogGroup.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLogGroup.Location = new System.Drawing.Point(232, 15);
            this.editLogGroup.Name = "editLogGroup";
            this.editLogGroup.Size = new System.Drawing.Size(469, 161);
            this.editLogGroup.TabIndex = 9;
            this.editLogGroup.TabStop = false;
            this.editLogGroup.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(391, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 20);
            this.button2.TabIndex = 16;
            this.button2.Text = "check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(391, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Enabled = false;
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(216, 85);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(156, 20);
            this.tbNewPassword.TabIndex = 14;
            this.tbNewPassword.Click += new System.EventHandler(this.TbNewPassword_Click);
            this.tbNewPassword.Leave += new System.EventHandler(this.TbNewPassword_Leave);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(216, 59);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(156, 20);
            this.tbOldPassword.TabIndex = 12;
            this.tbOldPassword.Click += new System.EventHandler(this.TbOldPassword_Click);
            this.tbOldPassword.Leave += new System.EventHandler(this.TbOldPassword_Leave);
            // 
            // tbEditPhone
            // 
            this.tbEditPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditPhone.Location = new System.Drawing.Point(216, 34);
            this.tbEditPhone.Mask = "(\\0\\0\\0) 000-0000";
            this.tbEditPhone.Name = "tbEditPhone";
            this.tbEditPhone.Size = new System.Drawing.Size(156, 20);
            this.tbEditPhone.TabIndex = 11;
            this.tbEditPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbEditPhone.Click += new System.EventHandler(this.TbEditPhone_Click);
            this.tbEditPhone.Leave += new System.EventHandler(this.TbEditPhone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текущий пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // saveLogButton
            // 
            this.saveLogButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLogButton.Location = new System.Drawing.Point(134, 122);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(190, 33);
            this.saveLogButton.TabIndex = 8;
            this.saveLogButton.Text = "Сохранить изменения";
            this.saveLogButton.UseVisualStyleBackColor = true;
            this.saveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Новый пароль";
            // 
            // goToLogEditButton
            // 
            this.goToLogEditButton.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLogEditButton.Location = new System.Drawing.Point(15, 104);
            this.goToLogEditButton.Name = "goToLogEditButton";
            this.goToLogEditButton.Size = new System.Drawing.Size(190, 53);
            this.goToLogEditButton.TabIndex = 10;
            this.goToLogEditButton.Text = "Логин и пароль";
            this.goToLogEditButton.UseVisualStyleBackColor = true;
            this.goToLogEditButton.Visible = false;
            this.goToLogEditButton.Click += new System.EventHandler(this.GoToLogEditButton_Click);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.clothes_storeDataSet1;
            // 
            // clothes_storeDataSet1
            // 
            this.clothes_storeDataSet1.DataSetName = "clothes_storeDataSet1";
            this.clothes_storeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.get_AddressTableAdapter.ClearBeforeFill = false;
            // 
            // ordersStatusBindingSource
            // 
            this.ordersStatusBindingSource.DataMember = "ordersStatus";
            this.ordersStatusBindingSource.DataSource = this.ordersStatus_DataSet;
            // 
            // ordersStatus_DataSet
            // 
            this.ordersStatus_DataSet.DataSetName = "ordersStatus_DataSet";
            this.ordersStatus_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersStatusTableAdapter
            // 
            this.ordersStatusTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // MainShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 445);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.groupName);
            this.Name = "MainShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainShop";
            this.Load += new System.EventHandler(this.MainShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.groupName.ResumeLayout(false);
            this.editAccountGroup.ResumeLayout(false);
            this.editAccountGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).EndInit();
            this.editLogGroup.ResumeLayout(false);
            this.editLogGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersStatus_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.PictureBox mainPicStore;
        private System.Windows.Forms.Button catalogueButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button editStoreButton;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.GroupBox editLogGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.MaskedTextBox tbEditPhone;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goToProfileEditButton;
        private System.Windows.Forms.Button goToLogEditButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox editAccountGroup;
        private System.Windows.Forms.Label logoPreviewLabel;
        private System.Windows.Forms.PictureBox logoPreview;
        private System.Windows.Forms.Button uploadLogoButton;
        private System.Windows.Forms.RichTextBox tbStoreInfo;
        private System.Windows.Forms.TextBox tbStoreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveAccChangesButton;
        private System.Windows.Forms.Button deleteLogoPreviewButton;
        private System.Windows.Forms.BindingSource getAddressBindingSource;
        private clothes_storeDataSet clothes_storeDataSet;
        private clothes_storeDataSetTableAdapters.Get_AddressTableAdapter get_AddressTableAdapter;
        private System.Windows.Forms.BindingSource ordersStatusBindingSource;
        private ordersStatus_DataSet ordersStatus_DataSet;
        private ordersStatus_DataSetTableAdapters.ordersStatusTableAdapter ordersStatusTableAdapter;
        private System.Windows.Forms.Button openAddressButton;
        private clothes_storeDataSet1 clothes_storeDataSet1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private clothes_storeDataSet1TableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}