using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class BiologyQuiz: Quiz
    {
        public BiologyQuiz()
        {

        }

        public override void setupQuiz()
        {
            /*
            foreach (Question question in Questions) {
                question = new Question()
            }
            */

            Question question = new Question("A frog is a type of mammal", false);
            Questions[0] = question;

        }

    }
}
