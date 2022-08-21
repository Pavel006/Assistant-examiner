
namespace Ghj
{
    partial class Login
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
            this.user_login = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_in_account = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(83, 132);
            this.user_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(132, 21);
            this.user_login.TabIndex = 0;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(83, 207);
            this.user_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(132, 21);
            this.user_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(122, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(119, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // login_in_account
            // 
            this.login_in_account.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.login_in_account.Location = new System.Drawing.Point(98, 281);
            this.login_in_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_in_account.Name = "login_in_account";
            this.login_in_account.Size = new System.Drawing.Size(100, 33);
            this.login_in_account.TabIndex = 4;
            this.login_in_account.Text = "Вход";
            this.login_in_account.UseVisualStyleBackColor = true;
            this.login_in_account.Click += new System.EventHandler(this.login_in_account_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 443);
            this.ControlBox = false;
            this.Controls.Add(this.login_in_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_login);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_in_account;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

