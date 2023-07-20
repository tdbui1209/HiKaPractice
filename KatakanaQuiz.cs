using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiKaPractice
{
    internal class KatakanaQuiz
    {
        static string data_path = @"D:\HiKaPractice\assets\katakana";
        string[] files = Directory.GetFiles(data_path);
        Stack<string> stack_questions = new Stack<string>();
        int total_questions;
        public KatakanaQuiz()
        {
            Random order = new Random();
            files = files.OrderBy(x => order.Next()).ToArray();
            stack_questions = new Stack<string>();
            foreach (string file in files)
            {
                stack_questions.Push(file);
            }
            total_questions = stack_questions.Count();
        }

        public string[] Draw()
        {
            string question_path = this.stack_questions.Pop();
            string correct_answer = Path.GetFileNameWithoutExtension(question_path);
            return new string[] { question_path, correct_answer };
        }

        public int get_total_question()
        {
            return total_questions;
        }
    }
}
