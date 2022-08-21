
namespace Ghj
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.to_reg = new System.Windows.Forms.LinkLabel();
            this.to_log = new System.Windows.Forms.LinkLabel();
            this.start_test = new System.Windows.Forms.Button();
            this.start_trening_test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // to_reg
            // 
            this.to_reg.AutoSize = true;
            this.to_reg.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.to_reg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.to_reg.Location = new System.Drawing.Point(681, 11);
            this.to_reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to_reg.Name = "to_reg";
            this.to_reg.Size = new System.Drawing.Size(77, 16);
            this.to_reg.TabIndex = 0;
            this.to_reg.TabStop = true;
            this.to_reg.Text = "Регистрация";
            this.to_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.to_reg_LinkClicked);
            // 
            // to_log
            // 
            this.to_log.AutoSize = true;
            this.to_log.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.to_log.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.to_log.Location = new System.Drawing.Point(631, 11);
            this.to_log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to_log.Name = "to_log";
            this.to_log.Size = new System.Drawing.Size(35, 16);
            this.to_log.TabIndex = 1;
            this.to_log.TabStop = true;
            this.to_log.Text = "Вход";
            this.to_log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.to_log_LinkClicked);
            // 
            // start_test
            // 
            this.start_test.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.start_test.Location = new System.Drawing.Point(405, 402);
            this.start_test.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_test.Name = "start_test";
            this.start_test.Size = new System.Drawing.Size(209, 82);
            this.start_test.TabIndex = 2;
            this.start_test.Text = "Начать тестирование";
            this.start_test.UseVisualStyleBackColor = true;
            this.start_test.Click += new System.EventHandler(this.start_test_Click);
            // 
            // start_trening_test
            // 
            this.start_trening_test.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_trening_test.Location = new System.Drawing.Point(188, 402);
            this.start_trening_test.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_trening_test.Name = "start_trening_test";
            this.start_trening_test.Size = new System.Drawing.Size(209, 82);
            this.start_trening_test.TabIndex = 3;
            this.start_trening_test.Text = "Начать тестирование\r\nв тренировачном режиме\r\n";
            this.start_trening_test.UseVisualStyleBackColor = true;
            this.start_trening_test.Click += new System.EventHandler(this.start_trening_test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 234);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.button1.Location = new System.Drawing.Point(214, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать статистику \r\nпользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.button2.Location = new System.Drawing.Point(405, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Показать статистику \r\nвсех пользователей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_trening_test);
            this.Controls.Add(this.start_test);
            this.Controls.Add(this.to_log);
            this.Controls.Add(this.to_reg);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощник экзаменатора";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel to_reg;
        private System.Windows.Forms.LinkLabel to_log;
        private System.Windows.Forms.Button start_test;
        private System.Windows.Forms.Button start_trening_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}