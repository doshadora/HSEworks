namespace WindowsFormsApp1
{
    partial class Display
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelsincelast = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adDataGridView = new System.Windows.Forms.DataGridView();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.stationTrainDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTrainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelsincelast);
            this.groupBox1.Controls.Add(this.LabelTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время";
            // 
            // labelsincelast
            // 
            this.labelsincelast.AutoSize = true;
            this.labelsincelast.ForeColor = System.Drawing.Color.Red;
            this.labelsincelast.Location = new System.Drawing.Point(13, 81);
            this.labelsincelast.Name = "labelsincelast";
            this.labelsincelast.Size = new System.Drawing.Size(35, 13);
            this.labelsincelast.TabIndex = 5;
            this.labelsincelast.Text = "label5";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.ForeColor = System.Drawing.Color.Red;
            this.LabelTime.Location = new System.Drawing.Point(13, 43);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(35, 13);
            this.LabelTime.TabIndex = 4;
            this.LabelTime.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время с момента отправления поезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущее время";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelAd);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Реклама";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 20);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(234, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(7, 36);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(0, 13);
            this.labelAd.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 103);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Конечная станция прибывшего поезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            // 
            // stationTrainBindingSource
            // 
            this.stationTrainBindingSource.DataMember = "StationTrain";
            // 
            // adBindingSource
            // 
            this.adBindingSource.DataMember = "Ad";
            // 
            // adDataGridView
            // 
            this.adDataGridView.AutoGenerateColumns = false;
            this.adDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adDataGridView.DataSource = this.adBindingSource;
            this.adDataGridView.Enabled = false;
            this.adDataGridView.Location = new System.Drawing.Point(747, 158);
            this.adDataGridView.Name = "adDataGridView";
            this.adDataGridView.Size = new System.Drawing.Size(300, 60);
            this.adDataGridView.TabIndex = 9;
            // 
            // stationsDataGridView
            // 
            this.stationsDataGridView.AutoGenerateColumns = false;
            this.stationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationsDataGridView.DataSource = this.stationsBindingSource;
            this.stationsDataGridView.Location = new System.Drawing.Point(782, 335);
            this.stationsDataGridView.Name = "stationsDataGridView";
            this.stationsDataGridView.Size = new System.Drawing.Size(250, 60);
            this.stationsDataGridView.TabIndex = 8;
            this.stationsDataGridView.Visible = false;
            // 
            // stationTrainDataGridView
            // 
            this.stationTrainDataGridView.AutoGenerateColumns = false;
            this.stationTrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationTrainDataGridView.DataSource = this.stationTrainBindingSource;
            this.stationTrainDataGridView.Location = new System.Drawing.Point(747, 262);
            this.stationTrainDataGridView.Name = "stationTrainDataGridView";
            this.stationTrainDataGridView.Size = new System.Drawing.Size(345, 52);
            this.stationTrainDataGridView.TabIndex = 9;
            this.stationTrainDataGridView.Visible = false;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 181);
            this.Controls.Add(this.adDataGridView);
            this.Controls.Add(this.stationTrainDataGridView);
            this.Controls.Add(this.stationsDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 260);
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTrainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label labelsincelast;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.BindingSource adBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private System.Windows.Forms.BindingSource stationTrainBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView adDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView stationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView stationTrainDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

