using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public abstract class Quiz
    {
        public Question[] questions = new Question[10];
        private int score;

        public Quiz()
        {

        }
        /*
        public Question[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }
        */
        public int Score
        {
            get { return score; }
            //set { score = value; } //we are protecting against the score being added to too much, only increase by 1!
        }

        public void AddOneToScore()
        {
            score = score + 1;
        }
        public abstract void setupQuiz();
        
    }
}
