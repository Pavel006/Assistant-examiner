
namespace Ghj
{
    partial class Registration
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
            this.registration_account = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_check = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // registration_account
            // 
            this.registration_account.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.registration_account.Location = new System.Drawing.Point(69, 316);
            this.registration_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registration_account.Name = "registration_account";
            this.registration_account.Size = new System.Drawing.Size(168, 33);
            this.registration_account.TabIndex = 10;
            this.registration_account.Text = "Зарегестрироваться";
            this.registration_account.UseVisualStyleBackColor = true;
            this.registration_account.Click += new System.EventHandler(this.registration_account_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(122, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(83, 180);
            this.user_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(132, 21);
            this.user_password.TabIndex = 7;
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(83, 105);
            this.user_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(132, 21);
            this.user_login.TabIndex = 6;
            this.user_login.TextChanged += new System.EventHandler(this.user_login_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(87, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторите пароль";
            // 
            // password_check
            // 
            this.password_check.Location = new System.Drawing.Point(83, 257);
            this.password_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_check.Name = "password_check";
            this.password_check.Size = new System.Drawing.Size(132, 21);
            this.password_check.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 443);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_check);
            this.Controls.Add(this.registration_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_login);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registration_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_check;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}