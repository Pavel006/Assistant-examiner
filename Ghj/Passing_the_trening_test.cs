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
    public partial class Passing_the_trening_test : Form
    {
        AccessC.ConectThisAccessWorker Con = new AccessC.ConectThisAccessWorker();
        DateTime t1, t2;
        int id_question_1 = 1, id_question_2 = 1, id_question_3 = 1, id_question_4 = 1, id_question_5 = 1;
        static public int Score = 0, Correct_answers = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            t2 = DateTime.Now;
            TimeSpan ts = t2 - t1;
            timer.Text = ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
        }

        private void finish_the_test_Click_1(object sender, EventArgs e)
        {
            string query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_1 + ";";
            string correct_answer1 = Con.Select(query);
            if ((question1_ansver1.Checked && question1_ansver1.Text == correct_answer1) ||
                (question1_ansver2.Checked && question1_ansver2.Text == correct_answer1) ||
                (question1_ansver3.Checked && question1_ansver3.Text == correct_answer1) ||
                (question1_ansver4.Checked && question1_ansver4.Text == correct_answer1))
            {
                query = $"SELECT Score FROM q.questions WHERE id_question LIKE " + id_question_1 + ";";
                Score += Convert.ToInt32(Con.Select(query));
                Correct_answers += 1;
            }

            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_2 + ";";
            correct_answer1 = Con.Select(query);
            if ((question2_answer1.Checked && question2_answer1.Text == correct_answer1) ||
                (question2_answer2.Checked && question2_answer2.Text == correct_answer1) ||
                (question2_answer3.Checked && question2_answer3.Text == correct_answer1) ||
                (question2_answer4.Checked && question2_answer4.Text == correct_answer1))
            {
                query = $"SELECT Score FROM q.questions WHERE id_question LIKE " + id_question_2 + ";";
                Score += Convert.ToInt32(Con.Select(query));
                Correct_answers += 1;
            }

            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_3 + ";";
            correct_answer1 = Con.Select(query);
            if ((question3_answer1.Checked && question3_answer1.Text == correct_answer1) ||
                (question3_answer2.Checked && question3_answer2.Text == correct_answer1) ||
                (question3_answer3.Checked && question3_answer3.Text == correct_answer1) ||
                (question3_answer4.Checked && question3_answer4.Text == correct_answer1))
            {
                query = $"SELECT Score FROM q.questions WHERE id_question LIKE " + id_question_3 + ";";
                Score += Convert.ToInt32(Con.Select(query));
                Correct_answers += 1;
            }

            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_4 + ";";
            correct_answer1 = Con.Select(query);
            if ((question4_answer1.Checked && question4_answer1.Text == correct_answer1) ||
                (question4_answer2.Checked && question4_answer2.Text == correct_answer1) ||
                (question4_answer3.Checked && question4_answer3.Text == correct_answer1) ||
                (question4_answer4.Checked && question4_answer4.Text == correct_answer1))
            {
                query = $"SELECT Score FROM q.questions WHERE id_question LIKE " + id_question_4 + ";";
                Score += Convert.ToInt32(Con.Select(query));
                Correct_answers += 1;
            }

            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_5 + ";";
            correct_answer1 = Con.Select(query);
            if ((question5_answer1.Checked && question5_answer1.Text == correct_answer1) ||
                (question5_answer2.Checked && question5_answer2.Text == correct_answer1) ||
                (question5_answer3.Checked && question5_answer3.Text == correct_answer1) ||
                (question5_answer4.Checked && question5_answer4.Text == correct_answer1))
            {
                query = $"SELECT Score FROM q.questions WHERE id_question LIKE " + id_question_5 + ";";
                Score += Convert.ToInt32(Con.Select(query));
                Correct_answers += 1;
            }

            this.AutoScroll = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            timer.Visible = false;
            Time = timer.Text;
            label2.Visible = true;

            label2.Text = $"Баллов за тест {Score}, Правильных ответов {Correct_answers}/5, Время прохождения теста {Time}";
        }

        static public string Time;

        string[] answers = new string[5];
        public Passing_the_trening_test()
        {
            InitializeComponent();
        }

        private void Passing_the_trening_test_Load(object sender, EventArgs e)
        {
            Con.OpenConnectic();
            timer1.Interval = 1000;
            timer1.Start();
            t1 = DateTime.Now;

            Random rnd = new Random();

            string query = "SELECT COUNT(*) FROM Q.Questions";
            int count = Convert.ToInt32(Con.Select(query)) + 1;

            for (int i = 0; i <= 5; i++)
            {
                while (id_question_1 == id_question_2 || id_question_1 == id_question_3 || id_question_1 == id_question_4 || id_question_1 == id_question_5)
                {
                    id_question_1 = rnd.Next(1, count);
                }
                while (id_question_2 == id_question_1 || id_question_2 == id_question_3 || id_question_2 == id_question_4 || id_question_2 == id_question_5)
                {
                    id_question_2 = rnd.Next(1, count);
                }
                while (id_question_3 == id_question_1 || id_question_3 == id_question_2 || id_question_3 == id_question_4 || id_question_3 == id_question_5)
                {
                    id_question_3 = rnd.Next(1, count);
                }
                while (id_question_4 == id_question_1 || id_question_4 == id_question_2 || id_question_4 == id_question_3 || id_question_4 == id_question_5)
                {
                    id_question_4 = rnd.Next(1, count);
                }
                while (id_question_5 == id_question_1 || id_question_5 == id_question_2 || id_question_5 == id_question_3 || id_question_5 == id_question_4)
                {
                    id_question_5 = rnd.Next(1, count);
                }
            }

            // генерация вопроса и ответов на вопрос 1
            query = "SELECT question FROM q.questions WHERE id_question LIKE " + id_question_1 + ";";
            question1.Text = Con.Select(query);
            for (int i = 1; i <= 3; i++)
            {
                query = $"SELECT Incorrect_answer_{i} FROM q.questions WHERE id_question LIKE " + id_question_1 + ";";
                answers[i] = Convert.ToString(Con.Select(query));
            }
            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_1 + ";";
            answers[4] = Con.Select(query);
            int[] counts = { 1, 2, 3, 4 };
            int[] c = { 1 };
            c[0] = counts[rnd.Next(0, counts.Length)];
            question1_ansver1.Text = answers[c[0]];
            counts = counts.Except<int>(c).ToArray<int>();

            c[0] = counts[rnd.Next(0, counts.Length)];
            question1_ansver2.Text = answers[c[0]];
            counts = counts.Except<int>(c).ToArray<int>();

            c[0] = counts[rnd.Next(0, counts.Length)];
            question1_ansver3.Text = answers[c[0]];
            counts = counts.Except<int>(c).ToArray<int>();

            c[0] = counts[rnd.Next(0, counts.Length)];
            question1_ansver4.Text = answers[c[0]];

            // генерация вопроса и ответов на вопрос 2
            query = "SELECT question FROM q.questions WHERE id_question LIKE " + id_question_2 + ";";
            question2.Text = Con.Select(query);
            for (int i = 1; i <= 3; i++)
            {
                query = $"SELECT Incorrect_answer_{i} FROM q.questions WHERE id_question LIKE " + id_question_2 + ";";
                answers[i] = Convert.ToString(Con.Select(query));
            }
            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_2 + ";";
            answers[4] = Con.Select(query);

            int[] counts2 = { 1, 2, 3, 4 };
            int[] c2 = { 1 };

            c2[0] = counts2[rnd.Next(0, counts2.Length)];
            question2_answer1.Text = answers[c2[0]];
            counts2 = counts2.Except<int>(c2).ToArray<int>();

            c2[0] = counts2[rnd.Next(0, counts2.Length)];
            question2_answer2.Text = answers[c2[0]];
            counts2 = counts2.Except<int>(c2).ToArray<int>();

            c2[0] = counts2[rnd.Next(0, counts2.Length)];
            question2_answer3.Text = answers[c2[0]];
            counts2 = counts2.Except<int>(c2).ToArray<int>();

            c2[0] = counts2[rnd.Next(0, counts2.Length)];
            question2_answer4.Text = answers[c2[0]];

            // генерация вопроса и ответов на вопрос 3
            query = "SELECT question FROM q.questions WHERE id_question LIKE " + id_question_3 + ";";
            question3.Text = Con.Select(query);
            for (int i = 1; i <= 3; i++)
            {
                query = $"SELECT Incorrect_answer_{i} FROM q.questions WHERE id_question LIKE " + id_question_3 + ";";
                answers[i] = Convert.ToString(Con.Select(query));
            }
            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_3 + ";";
            answers[4] = Con.Select(query);

            int[] counts3 = { 1, 2, 3, 4 };
            int[] c3 = { 1 };

            c3[0] = counts3[rnd.Next(0, counts3.Length)];
            question3_answer1.Text = answers[c3[0]];
            counts3 = counts3.Except<int>(c3).ToArray<int>();

            c3[0] = counts3[rnd.Next(0, counts3.Length)];
            question3_answer2.Text = answers[c3[0]];
            counts3 = counts3.Except<int>(c3).ToArray<int>();

            c3[0] = counts3[rnd.Next(0, counts3.Length)];
            question3_answer3.Text = answers[c3[0]];
            counts3 = counts3.Except<int>(c3).ToArray<int>();

            c3[0] = counts3[rnd.Next(0, counts3.Length)];
            question3_answer4.Text = answers[c3[0]];

            // генерация вопроса и ответов на вопрос 4
            query = "SELECT question FROM q.questions WHERE id_question LIKE " + id_question_4 + ";";
            question4.Text = Con.Select(query);
            for (int i = 1; i <= 3; i++)
            {
                query = $"SELECT Incorrect_answer_{i} FROM q.questions WHERE id_question LIKE " + id_question_4 + ";";
                answers[i] = Convert.ToString(Con.Select(query));
            }
            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_4 + ";";
            answers[4] = Con.Select(query);

            int[] counts4 = { 1, 2, 3, 4 };
            int[] c4 = { 1 };

            c4[0] = counts4[rnd.Next(0, counts4.Length)];
            question4_answer1.Text = answers[c4[0]];
            counts4 = counts4.Except<int>(c4).ToArray<int>();

            c4[0] = counts4[rnd.Next(0, counts4.Length)];
            question4_answer2.Text = answers[c4[0]];
            counts4 = counts4.Except<int>(c4).ToArray<int>();

            c4[0] = counts4[rnd.Next(0, counts4.Length)];
            question4_answer3.Text = answers[c4[0]];
            counts4 = counts4.Except<int>(c4).ToArray<int>();

            c4[0] = counts4[rnd.Next(0, counts4.Length)];
            question4_answer4.Text = answers[c4[0]];

            // генерация вопроса и ответов на вопрос 5
            query = "SELECT question FROM q.questions WHERE id_question LIKE " + id_question_5 + ";";
            question5.Text = Con.Select(query);
            for (int i = 1; i <= 3; i++)
            {
                query = $"SELECT Incorrect_answer_{i} FROM q.questions WHERE id_question LIKE " + id_question_5 + ";";
                answers[i] = Convert.ToString(Con.Select(query));
            }
            query = $"SELECT Correct_answer FROM q.questions WHERE id_question LIKE " + id_question_5 + ";";
            answers[4] = Con.Select(query);

            int[] counts5 = { 1, 2, 3, 4 };
            int[] c5 = { 1 };

            c5[0] = counts5[rnd.Next(0, counts5.Length)];
            question5_answer1.Text = answers[c5[0]];
            counts5 = counts5.Except<int>(c5).ToArray<int>();

            c5[0] = counts5[rnd.Next(0, counts5.Length)];
            question5_answer2.Text = answers[c5[0]];
            counts5 = counts5.Except<int>(c5).ToArray<int>();

            c5[0] = counts5[rnd.Next(0, counts5.Length)];
            question5_answer3.Text = answers[c5[0]];
            counts5 = counts5.Except<int>(c5).ToArray<int>();

            c5[0] = counts5[rnd.Next(0, counts5.Length)];
            question5_answer4.Text = answers[c5[0]];

            query = "SELECT correct_answer FROM questions WHERE id_question LIKE " + id_question_1 + ";";
            test_answers.Text += "1. " + Convert.ToString(Con.Select(query)) + "\n";
            query = "SELECT correct_answer FROM questions WHERE id_question LIKE " + id_question_2 + ";";
            test_answers.Text += "2. " + Convert.ToString(Con.Select(query)) + "\n";
            query = "SELECT correct_answer FROM questions WHERE id_question LIKE " + id_question_3 + ";";
            test_answers.Text += "3. " + Convert.ToString(Con.Select(query)) + "\n";
            query = "SELECT correct_answer FROM questions WHERE id_question LIKE " + id_question_4 + ";";
            test_answers.Text += "4. " + Convert.ToString(Con.Select(query)) + "\n";
            query = "SELECT correct_answer FROM questions WHERE id_question LIKE " + id_question_5 + ";";
            test_answers.Text += "5. " + Convert.ToString(Con.Select(query)) + "\n";
        }
    }
}
