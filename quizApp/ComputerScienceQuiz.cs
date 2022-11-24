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
            questions.Append(question);

            Question question1 = new Question("", false);
            questions.Append(question1);

            Question question2 = new Question("", true);
            questions.Append(question2);

            Question question3 = new Question("", false);
            questions.Append(question3);

            Question question4 = new Question("", true);
            questions.Append(question4);

            Question question5 = new Question("", true);
            questions.Append(question5);

            Question question6 = new Question("", true);
            questions.Append(question6);

            Question question7 = new Question("", false);
            questions.Append(question7);

            Question question8 = new Question("", false);
            questions.Append(question8);

            Question question9 = new Question("", true);
            questions.Append(question9);
        }
    }
}
