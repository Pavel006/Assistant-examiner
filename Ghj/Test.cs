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
    public partial class Test : Form
    {
        private DataTable table = null;
        private System.Data.SqlClient.SqlDataAdapter adapter = null;
        AccessC.ConectThisAccessWorker Con = new AccessC.ConectThisAccessWorker();
        public Test()
        {
            InitializeComponent();
        }
        private void Test_Load(object sender, EventArgs e)
        {
            Con.OpenConnectic();
        }
        // переход на форму авторизации
        private void to_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }
        //переход на форму регистрации
        private void to_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        // переход на форму выполнения теста
        private void start_test_Click(object sender, EventArgs e)
        {
            if (Login.is_login)
            {
                Passing_the_test start_test = new Passing_the_test();
                start_test.Show();
            }
            else
            {
                MessageBox.Show("Вы не авторизованы");
            }
        }
        // вывод статистики авторизованного пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.is_login)
            {
                string query = "SELECT Логин, Баллы, Время_выполнения, Оценка FROM results WHERE Логин LIKE '" + Login.login + "';";
                dataGridView1.DataSource = Con.fill(query);

                // вывод среднего балла 
                label2.Text = "";
                query = "SELECT Баллы FROM results WHERE Логин LIKE '" + Login.login + "';";
                string ball = Con.Select(query).Replace(" ", "");
                double vfs = 0;
                for (int i = 0; i < ball.Length; i++)
                {
                    vfs += Convert.ToDouble(ball[i] + ",0");
                }
                vfs = vfs / ball.Length;
                label2.Text += "Средний балл: " + Convert.ToString(Math.Round(vfs, 2));

                // вывод средней оценки
                query = "SELECT Оценка FROM results WHERE Логин LIKE '" + Login.login + "';";
                string oc = Con.Select(query).Replace(" ", "");
                double vf = 0;
                for (int i = 0; i < oc.Length; i++)
                {
                    vf += Convert.ToDouble(oc[i] + ",0");
                }
                vf = vf / oc.Length;
                label2.Text += "     " + "Средняя оценка: " + Convert.ToString(Math.Round(vf, 2));
            }
            else
            {
                MessageBox.Show("Вы не авторизованы");
            }
        }

        // переход на форму выполнения теста в тренировачном режиме
        private void start_trening_test_Click(object sender, EventArgs e)
        {
            if (Login.is_login)
            {
                Passing_the_trening_test start_trening_test = new Passing_the_trening_test();
                start_trening_test.Show();
            }
            else
            {
                MessageBox.Show("Вы не авторизованы");
            }
        }

        // вывод статистики всех пользователей
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT Логин, Баллы, Время_выполнения, Оценка FROM results ;";
            dataGridView1.DataSource = Con.fill(query);

            label2.Text = "";   
            query = "SELECT Баллы FROM results WHERE Логин LIKE '" + Login.login + "';";
            string ball = Con.Select(query).Replace(" ", "");
            double vfs = 0;
            for (int i = 0; i < ball.Length; i++)
            {
                vfs += Convert.ToDouble(ball[i] + ",0");
            }
            vfs = vfs / ball.Length;

            query = "SELECT Оценка FROM results WHERE Логин LIKE '" + Login.login + "';";
            string oc = Con.Select(query).Replace(" ", "");
            double vf = 0;
            for (int i = 0; i < oc.Length; i++)
            {
                vf += Convert.ToDouble(oc[i] + ",0");
            }
            vf = vf / oc.Length;

        }
    }
}
