using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghj
{
    public partial class Registration : Form
    {
        AccessC.ConectThisAccessWorker Con = new AccessC.ConectThisAccessWorker();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Con.OpenConnectic();
        }

        private void registration_account_Click(object sender, EventArgs e)
        {

            if (user_password.Text == password_check.Text)
            {
                // внесение введеных данных пользователем в бд
                string query = $"INSERT INTO `q`.`users` (`login`, `password`) VALUES ('{Convert.ToString(user_login.Text)}', '{Convert.ToString(user_password.Text)}')";
                Con.InsertAndDeleteAndUpdate(query);
                MessageBox.Show("Вы успешно зарегестрировались, теперь выполните вход в аккаунт");
                this.Close();
            }
            else
            {
                errorProvider1.SetError(password_check, "Пароли не совпадают");
            }
        }

        private void user_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
