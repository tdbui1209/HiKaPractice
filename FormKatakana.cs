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
    public partial class Katakana : Form
    {
        string question;
        string correct_answer;
        int total_question;
        int question_remaining;
        int score;

        List<string> questions = new List<string>();
        List<string> history_answer = new List<string>();
        List<string> history_correct_answer = new List<string>();

        KatakanaQuiz katakanaQuiz;
        public Katakana()
        {
            InitializeComponent();
            katakanaQuiz = new KatakanaQuiz();
            score = 0;
            total_question = katakanaQuiz.get_total_question();
            question_remaining = total_question;
            draw();
        }

        void draw()
        {
            textBox_answer.Text = "";
            question_remaining--;
            label_question_remaining.Text = "Số câu còn lại: " + question_remaining.ToString();
            try
            {
                string[] draw = katakanaQuiz.Draw();
                question = draw[0];
                correct_answer = draw[1];
                label_question.Text = question;
            }
            catch (Exception ex)
            {
                Form form = new FormResult(questions, score, history_answer, history_correct_answer);
                form.ShowDialog();
            }
        }

        void submit_answer()
        {
            String answer = textBox_answer.Text;
            answer = answer.Trim().ToLower();

            if (answer.Length > 0 && answer == correct_answer)
            {
                score++;
                label_result.Text = "正しい";
                label_result.ForeColor = Color.Green;
            }
            else
            {
                label_result.Text = "間違い!" + " Đáp án đúng là: " + correct_answer;
                label_result.ForeColor = Color.Red;
            }
            label_result.Visible = true;
            label_result.TextAlign = ContentAlignment.MiddleCenter;

            questions.Add(question);
            history_answer.Add(answer);
            history_correct_answer.Add(correct_answer);

            draw();
        }

        void button_submit_Click(object sender, EventArgs e)
        {
            submit_answer();
        }

        private void button_submit_KeyDown(object sender, KeyEventArgs e)
        {

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
