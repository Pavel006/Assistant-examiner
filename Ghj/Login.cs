using System;
using System.Windows.Forms;

namespace Ghj
{
    public partial class Login : Form
    {
        static public bool is_login;
        static public string login;
        static public int id;
        string pass;
        // подключение к базе данных
        AccessC.ConectThisAccessWorker Con = new AccessC.ConectThisAccessWorker();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Con.OpenConnectic();
        }
        public void login_in_account_Click(object sender, EventArgs e)
        {
            // получение пароля пользователя про введеному логину
            string query = "SELECT password FROM q.users WHERE login LIKE '" + user_login.Text + "';";
            pass = Con.Select(query).Replace(" ", "");

            // получение id пользователя по введному логину
            query = "SELECT id FROM q.users WHERE login LIKE '" + user_login.Text + "';";
            id = Convert.ToInt32(Con.Select(query));

            // сравнение введеного пользователем пароля с паролем полученным из бд
            if (pass == user_password.Text)
            {
                is_login = true;
                login = user_login.Text;
                MessageBox.Show("Вы успешно авторизовались");
                this.Close();
            }
            else
            {
                is_login = false;
                errorProvider1.SetError(user_password, "Пароль не верный");
}            }
        }
    }
