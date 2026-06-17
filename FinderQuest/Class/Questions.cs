using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.Class
{
    public class Questions
    {
        private string question;
        private string answer;
        private int score;

        public Questions(string question, string answer, int score)
        {
            this.Question = question;
            this.Answer = answer;
            this.Score = score;
        }

        public string Question
        {
            get => question;
            set
            {
                if (value == "")
                {
                    throw new Exception("Question cannot be empty.");
                }
                else
                {
                    question = value;
                }
            }
        }
        public string Answer
        {
            get => answer;
            set
            {
                if (value == "")
                {
                    throw new Exception("Answer cannot be empty.");
                }
                else
                {
                    answer = value;
                }
            }
        }
        public int Score
        {
            get => score;
            set
            {
                if (value >= 0)
                {
                    score = value;

                }
                else
                {
                    score = 0;
                }
            }
        }
    }
}
