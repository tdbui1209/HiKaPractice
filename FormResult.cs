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
        public FormResult(List<string> questions_list, List<string> answers_list, List<string> user_answers_list, int score)
        {
            InitializeComponent();
            int total_question = questions_list.Count();
            double correct_percent = (double)score / total_question * 100;
            correct_percent = Math.Round(correct_percent, 2);

            label_correct_num.Text = score.ToString() + "/" + total_question.ToString();
            label_correct_percent.Text = correct_percent.ToString() + "%";

            for (int i = 0; i < questions_list.Count(); i++)
            {
                ListViewItem item = new ListViewItem(questions_list[i]);
                item.SubItems.Add(answers_list[i]);
                item.SubItems.Add(user_answers_list[i]);

                listView_result.Items.Add(item);
            }
        }
    }
}
