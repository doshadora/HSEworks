namespace courseWork2
{
    partial class SignIn
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
            this.signInButton = new System.Windows.Forms.Button();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordLog = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.tbPhoneLog = new System.Windows.Forms.MaskedTextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbGoToSignIn = new System.Windows.Forms.Button();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.tbBackToLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(49, 130);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(128, 23);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Зарегистрироваться";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Visible = false;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.Location = new System.Drawing.Point(62, 41);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(100, 20);
            this.tbFIO.TabIndex = 1;
            this.tbFIO.Text = "ФИО";
            this.tbFIO.Visible = false;
            this.tbFIO.Click += new System.EventHandler(this.TbFIO_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(62, 93);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "Пароль";
            this.tbPassword.Visible = false;
            this.tbPassword.Click += new System.EventHandler(this.TbPassword_Click);
            // 
            // tbPasswordLog
            // 
            this.tbPasswordLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordLog.Location = new System.Drawing.Point(62, 67);
            this.tbPasswordLog.Name = "tbPasswordLog";
            this.tbPasswordLog.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordLog.TabIndex = 6;
            this.tbPasswordLog.Text = "Пароль";
            this.tbPasswordLog.Click += new System.EventHandler(this.TbPasswordLog_Click);
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(49, 101);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(128, 23);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Войти";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // tbPhoneLog
            // 
            this.tbPhoneLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhoneLog.Location = new System.Drawing.Point(62, 41);
            this.tbPhoneLog.Mask = "(000) 000-0000";
            this.tbPhoneLog.Name = "tbPhoneLog";
            this.tbPhoneLog.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneLog.TabIndex = 8;
            this.tbPhoneLog.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(62, 67);
            this.tbPhone.Mask = "(000) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 9;
            this.tbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPhone.Visible = false;
            // 
            // tbGoToSignIn
            // 
            this.tbGoToSignIn.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoToSignIn.Location = new System.Drawing.Point(49, 130);
            this.tbGoToSignIn.Name = "tbGoToSignIn";
            this.tbGoToSignIn.Size = new System.Drawing.Size(128, 23);
            this.tbGoToSignIn.TabIndex = 10;
            this.tbGoToSignIn.Text = "Зарегистрироваться";
            this.tbGoToSignIn.UseVisualStyleBackColor = true;
            this.tbGoToSignIn.Click += new System.EventHandler(this.TbGoToSignIn_Click);
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.Location = new System.Drawing.Point(44, 5);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(132, 25);
            this.labelLogIn.TabIndex = 11;
            this.labelLogIn.Text = "Войти в аккаунт";
            // 
            // tbBackToLog
            // 
            this.tbBackToLog.Font = new System.Drawing.Font("Javanese Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBackToLog.Location = new System.Drawing.Point(49, 159);
            this.tbBackToLog.Name = "tbBackToLog";
            this.tbBackToLog.Size = new System.Drawing.Size(127, 49);
            this.tbBackToLog.TabIndex = 12;
            this.tbBackToLog.Text = "Вернуться к регистрации";
            this.tbBackToLog.UseVisualStyleBackColor = true;
            this.tbBackToLog.Visible = false;
            this.tbBackToLog.Click += new System.EventHandler(this.TbBackToLog_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 220);
            this.Controls.Add(this.tbBackToLog);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.tbGoToSignIn);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPhoneLog);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.tbPasswordLog);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.signInButton);
            this.Name = "SignIn";
            this.Text = "C&B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordLog;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.MaskedTextBox tbPhoneLog;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Button tbGoToSignIn;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Button tbBackToLog;
    }
}

