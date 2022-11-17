using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class PsychologyQuiz : Quiz
    {
        public PsychologyQuiz()
        {

        }

        public override void setupQuiz()
        {
            Question question = new Question("The brain is divided into 4 lobes: temporal lobe, occipital lobe, fronatl lobe, parietal lobe", true);
            Questions.Append(question);

            Question question1 = new Question("phobias can be treated using flooding", true);
            Questions.Append(question);

            Question question2 = new Question("An example of an infaraidian rhythm is the menstrual cycle", true);
            Questions.Append(question);

            Question question3 = new Question("Freud suggested the personality is split into 3 parts: the id, ego, and megaego", false);
            Questions.Append(question);

            Question question4 = new Question("", false);
            Questions.Append(question);

            Question question5 = new Question("", true);
            Questions.Append(question);

            Question question6 = new Question("Informational social influence is conforming to whoever you believe has the best information", true);
            Questions.Append(question);

            Question question7 = new Question("", false);
            Questions.Append(question);

            Question question8 = new Question("A null hypothesis is a hypothesis that states theres no difference", true);
            Questions.Append(question);

            Question question9 = new Question("Short term memory lasts 2 days ", false);
            Questions.Append(question);
        }
    }
}
