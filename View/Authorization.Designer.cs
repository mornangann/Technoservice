namespace ОООТехносервис
{
    partial class Authorization
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
            this.logIn = new System.Windows.Forms.Button();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.textBoxLogIn = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(238, 208);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(277, 34);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Вход";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Location = new System.Drawing.Point(175, 167);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(45, 13);
            this.labelPasswd.TabIndex = 1;
            this.labelPasswd.Text = "Пароль";
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Location = new System.Drawing.Point(175, 127);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(38, 13);
            this.labelLogIn.TabIndex = 2;
            this.labelLogIn.Text = "Логин";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(332, 50);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(73, 13);
            this.labelAuth.TabIndex = 3;
            this.labelAuth.Text = "Авторизация";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(556, 38);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(174, 36);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Выход";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // textBoxLogIn
            // 
            this.textBoxLogIn.Location = new System.Drawing.Point(238, 120);
            this.textBoxLogIn.Name = "textBoxLogIn";
            this.textBoxLogIn.Size = new System.Drawing.Size(277, 20);
            this.textBoxLogIn.TabIndex = 5;
            this.textBoxLogIn.Text = "loginDExvq2018";
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(238, 167);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(277, 20);
            this.textBoxPasswd.TabIndex = 6;
            this.textBoxPasswd.Text = "hX0wJz";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxLogIn);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.logIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.TextBox textBoxLogIn;
        private System.Windows.Forms.TextBox textBoxPasswd;
    }
}

