using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiKaPractice
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_hiragana_Click(object sender, EventArgs e)
        {
            Form form = new FormQuiz("hiragana");
            form.ShowDialog();
        }

        private void button_katakana_Click(object sender, EventArgs e)
        {
            Form form = new FormQuiz("katakana");
            form.ShowDialog();
        }
    }
}
