using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class ComputerScienceQuiz : Quiz
    {
        public ComputerScienceQuiz()
        {

        }

        public override void setupQuiz()
        {
            Question question = new Question("A Binary search must be unsorted to find the data item", false);
            Questions.Append(question);

            Question question1 = new Question("", false);
            Questions.Append(question1);

            Question question2 = new Question("", true);
            Questions.Append(question2);

            Question question3 = new Question("", false);
            Questions.Append(question3);

            Question question4 = new Question("", true);
            Questions.Append(question4);

            Question question5 = new Question("", true);
            Questions.Append(question5);

            Question question6 = new Question("", true);
            Questions.Append(question6);

            Question question7 = new Question("", false);
            Questions.Append(question7);

            Question question8 = new Question("", false);
            Questions.Append(question8);

            Question question9 = new Question("", true);
            Questions.Append(question9);
        }
    }
}
