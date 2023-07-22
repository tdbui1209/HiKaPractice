using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiKaPractice
{
    public partial class FormQuiz : Form
    {
        Question[] questions;
        List<string> questions_list = new List<string>();
        List<string> answers_list = new List<string>();
        List<string> user_answers_list = new List<string>();

        int total_questions;
        int score = 0;
        int count = 0;

        string question;
        string answer;
        string user_answer;

        public FormQuiz(string quizName)
        {
            InitializeComponent();
            Text = quizName.ToUpper();

            Quiz quiz = new Quiz(quizName);
            questions = quiz.getQuestions();
            total_questions = quiz.getTotalQuestions();
            draw();
        }

        private void draw()
        {
            if (total_questions - count - 1 < 0)
            {
                Form form = new FormResult(questions_list, answers_list, user_answers_list, score);
                form.ShowDialog();
            }
            else
            {
                label_question_remaining.Text = "Số câu còn lại: " + (total_questions - count - 1).ToString();
                textBox_answer.Text = "";
                question = questions[count].question;
                answer = questions[count].answer;
                label_question.Text = question;
            }
        }

        private void submit_answer()
        {
            user_answer = textBox_answer.Text;
            user_answer = user_answer.Trim().ToLower();

            if (user_answer.Equals(answer))
            {
                score++;
                label_result.Text = "正しい";
                label_result.ForeColor = Color.Green;
            }
            else
            {
                label_result.Text = "間違い!" + " Đáp án đúng là: " + answer;
                label_result.ForeColor = Color.Red;
            }
            label_result.Visible = true;
            label_result.TextAlign = ContentAlignment.MiddleCenter;

            questions_list.Add(question);
            answers_list.Add(answer);
            user_answers_list.Add(user_answer);

            count++;
            draw();
        }

        void button_submit_Click(object sender, EventArgs e)
        {
            submit_answer();
        }



        private void textBox_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_answer();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
