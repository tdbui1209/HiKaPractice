using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiKaPractice
{
    public partial class FormResult : Form
    {
        int total_question;
        int correct;
        public FormResult(int total_question, int correct,
            List<string> history_answer, List<string> history_correct_answer)
        {
            InitializeComponent();
            this.total_question = total_question;
            this.correct = correct;
            double correct_percent = (double)correct / total_question * 100;
            correct_percent = Math.Round(correct_percent, 2);

            label_correct_num.Text = correct.ToString() + "/" + total_question.ToString();
            label_correct_percent.Text = correct_percent.ToString() + "%";
        }
    }
}
