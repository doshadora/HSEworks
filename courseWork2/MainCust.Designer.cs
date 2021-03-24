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
            this.menuList = new System.Windows.Forms.ListBox();
            this.menuBox = new System.Windows.Forms.TextBox();
            this.cataloguePanel = new System.Windows.Forms.TableLayoutPanel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.productLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.productGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuList
            // 
            this.menuList.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuList.FormattingEnabled = true;
            this.menuList.ItemHeight = 25;
            this.menuList.Items.AddRange(new object[] {
            "😩 Каталог",
            "😢 Мой аккаунт",
            "😰 Мои заказы",
            "😱 Корзина"});
            this.menuList.Location = new System.Drawing.Point(656, 36);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(128, 104);
            this.menuList.TabIndex = 7;
            this.menuList.Visible = false;
            this.menuList.MouseLeave += new System.EventHandler(this.MenuList_MouseLeave);
            // 
            // menuBox
            // 
            this.menuBox.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBox.Location = new System.Drawing.Point(656, 12);
            this.menuBox.Name = "menuBox";
            this.menuBox.ReadOnly = true;
            this.menuBox.Size = new System.Drawing.Size(128, 32);
            this.menuBox.TabIndex = 8;
            this.menuBox.Text = "        😭Меню😭        ";
            this.menuBox.MouseHover += new System.EventHandler(this.MenuBox_MouseHover);
            // 
            // cataloguePanel
            // 
            this.cataloguePanel.AutoScroll = true;
            this.cataloguePanel.ColumnCount = 4;
            this.cataloguePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cataloguePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cataloguePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cataloguePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cataloguePanel.Location = new System.Drawing.Point(136, 47);
            this.cataloguePanel.MaximumSize = new System.Drawing.Size(600, 400);
            this.cataloguePanel.Name = "cataloguePanel";
            this.cataloguePanel.RowCount = 1;
            this.cataloguePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cataloguePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.cataloguePanel.Size = new System.Drawing.Size(600, 400);
            this.cataloguePanel.TabIndex = 9;
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(6, 19);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(135, 195);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 15;
            this.picPreview.TabStop = false;
            // 
            // productGroup
            // 
            this.productGroup.Controls.Add(this.productLabel);
            this.productGroup.Controls.Add(this.picPreview);
            this.productGroup.Location = new System.Drawing.Point(821, 47);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(145, 242);
            this.productGroup.TabIndex = 16;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "groupBox1";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(7, 221);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(35, 13);
            this.productLabel.TabIndex = 16;
            this.productLabel.Text = "label1";
            // 
            // MainCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 459);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.productGroup);
            this.Controls.Add(this.cataloguePanel);
            this.Controls.Add(this.menuBox);
            this.Name = "MainCust";
            this.Text = "MainCust";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.productGroup.ResumeLayout(false);
            this.productGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox menuList;
        private System.Windows.Forms.TextBox menuBox;
        private System.Windows.Forms.TableLayoutPanel cataloguePanel;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.GroupBox productGroup;
        private System.Windows.Forms.Label productLabel;
    }
}