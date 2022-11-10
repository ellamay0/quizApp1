using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
     public abstract class Question
    {
        private string question;
        private bool correctAnswer; //keepping track of what they answered, so we know to aske them again
        private bool answer; //is the answer true or false

        public Question(string question, bool answer)
        {
            this.question = question;
            this.correctAnswer = false;
            this.answer = answer;
        }

        public string QuestionText
        {
            get { return QuestionText; }
        }
        public bool Answer
        {
            get { return answer;  } //we only have a getter because we don't want anyone changing the answer after we have set it
        }
    }
}
