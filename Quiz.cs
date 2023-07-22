using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiKaPractice
{
    internal class Quiz
    {
        private Question[] questions;
        public Quiz(string quizName) 
        {
            string pathToQuestions = @"D:\HiKaPractice\assets\";
            if (quizName == "katakana")
            {
                pathToQuestions += "katakanaQuestions.json";
            }
            else if (quizName == "hiragana")
            {
                pathToQuestions += "hiraganaQuestions.json";
            }
            questions = loadJson(pathToQuestions);
            suffleQuestions();
        }

        private Question[] loadJson(string pathToQuestions)
        {
            using (StreamReader reader = new StreamReader(pathToQuestions))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Question[]>(json);
            }
        }

        private void suffleQuestions()
        {
            Random order = new Random();
            questions = questions.OrderBy(x => order.Next()).ToArray();
        }

        public Question[] getQuestions()
        {
            return questions;
        }

        public int getTotalQuestions()
        {
            return questions.Length;
        }
    }
}
