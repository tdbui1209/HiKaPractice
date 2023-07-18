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
    public partial class FormKatakana : Form
    {
        string image_path;
        string correct_answer;
        int score;
        KatakanaQuiz katakanaQuiz;
        public FormKatakana()
        {
            InitializeComponent();
            katakanaQuiz = new KatakanaQuiz();
            score = 0;
            draw();
        }

        void draw()
        {
            string[] draw = katakanaQuiz.Draw();
            image_path = draw[0];
            correct_answer = draw[1];
            pictureBox_question.Image = Image.FromFile(image_path);
        }

        void button_submit_Click(object sender, EventArgs e)
        {
            String answer = textBox_answer.Text;
            answer = answer.Trim().ToLower();
            if (answer.Length > 0 && answer == correct_answer)
            {
                score++;
                label_result.Text = "正しい";
                label_result.Visible = true;
                label_result.ForeColor = Color.Green;
            }
            else
            {
                label_result.Text = "間違い";
                label_result.Visible = true;
                label_result.ForeColor = Color.Red;
            }
            draw();
        }
    }
}
