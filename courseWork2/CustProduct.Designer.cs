namespace courseWork2
{
    partial class CustProduct
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProdInfo = new System.Windows.Forms.RichTextBox();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbProdCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(107, 222);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(138, 20);
            this.tbPrice.TabIndex = 25;
            // 
            // tbProdInfo
            // 
            this.tbProdInfo.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdInfo.Location = new System.Drawing.Point(12, 79);
            this.tbProdInfo.Name = "tbProdInfo";
            this.tbProdInfo.ReadOnly = true;
            this.tbProdInfo.Size = new System.Drawing.Size(233, 109);
            this.tbProdInfo.TabIndex = 24;
            this.tbProdInfo.Text = "";
            // 
            // tbProdName
            // 
            this.tbProdName.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdName.Location = new System.Drawing.Point(12, 41);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.ReadOnly = true;
            this.tbProdName.Size = new System.Drawing.Size(233, 32);
            this.tbProdName.TabIndex = 23;
            // 
            // tbProdCode
            // 
            this.tbProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdCode.Location = new System.Drawing.Point(107, 194);
            this.tbProdCode.MaxLength = 10;
            this.tbProdCode.Name = "tbProdCode";
            this.tbProdCode.ReadOnly = true;
            this.tbProdCode.Size = new System.Drawing.Size(138, 20);
            this.tbProdCode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Артикул";
            // 
            // prodPic
            // 
            this.prodPic.Location = new System.Drawing.Point(251, 12);
            this.prodPic.Name = "prodPic";
            this.prodPic.Size = new System.Drawing.Size(187, 270);
            this.prodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodPic.TabIndex = 27;
            this.prodPic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Информация о товаре";
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(12, 258);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(111, 24);
            this.ActionButton.TabIndex = 29;
            this.ActionButton.Text = "ActionButton";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 24);
            this.button2.TabIndex = 30;
            this.button2.Text = "Каталог";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CustProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodPic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProdInfo);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.tbProdCode);
            this.Controls.Add(this.label1);
            this.Name = "CustProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustProduct";
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.RichTextBox tbProdInfo;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.TextBox tbProdCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox prodPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button button2;
    }
}