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
        Stack<Question> stack_questions = new Stack<Question>();
        int total_questions;
        public KatakanaQuiz()
        {
            Random order = new Random();
            Question[] questions = new Quiz("katakana").getQuestions();
            questions = questions.OrderBy(x => order.Next()).ToArray();
            foreach (Question question in questions)
            {
                stack_questions.Push(question);
            }
            total_questions = stack_questions.Count();
        }

        public string[] Draw()
        {
            Question question = stack_questions.Pop();
            return new string[] { question.question, question.answer };
        }

        public int get_total_question()
        {
            return total_questions;
        }
    }
}
