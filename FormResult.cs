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
        public FormResult(List<string> questions, int correct,
            List<string> history_answer, List<string> history_correct_answer)
        {
            InitializeComponent();
            int total_question = questions.Count();
            double correct_percent = (double)correct / total_question * 100;
            correct_percent = Math.Round(correct_percent, 2);

            label_correct_num.Text = correct.ToString() + "/" + total_question.ToString();
            label_correct_percent.Text = correct_percent.ToString() + "%";

            for (int i = 0;  i < questions.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = questions[i];
                listView_result.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, history_correct_answer[i]);
                item.SubItems.Add(subitem);

                subitem = new ListViewItem.ListViewSubItem(item, history_answer[i]);

                if (history_correct_answer[i].Equals(history_answer[i]))
                {
                    subitem.ForeColor = Color.Green;
                }
                else
                {
                    subitem.ForeColor = Color.Red;
                }
                
                item.SubItems.Add(subitem);


            }
        }
    }
}
