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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hiragana_Click(object sender, EventArgs e)
        {

        }

        private void button_katakana_Click(object sender, EventArgs e)
        {
            Form form = new FormKatakana();
            form.ShowDialog();
        }
    }
}
