using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public abstract class Quiz
    {
        private Question[] questions = new Question[15];
        private int score;

        public Quiz()
        {

        }
        public Question[] Questions
        {
            get { return Questions; }
            set { Questions = value; }
        }
        public abstract void setupQuiz();
        
    }
}
