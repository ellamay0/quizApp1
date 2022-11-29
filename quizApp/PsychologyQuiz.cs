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
            questions.Add(question);

            Question question1 = new Question("phobias can be treated using flooding", true);
            questions.Add(question1);

            Question question2 = new Question("An example of an infaraidian rhythm is the menstrual cycle", true);
            questions.Add(question2);

            Question question3 = new Question("Freud suggested the personality is split into 3 parts: the id, ego, and megaego", false);
            questions.Add(question3);

            Question question4 = new Question("The biological approach suggests that everything biological is first psychological ", false);
            questions.Add(question4);

            Question question5 = new Question("The Autonomic nrevous system is divided into the sympathetic and parasympathetic subsections", true);
            questions.Add(question5);

            Question question6 = new Question("Informational social influence is conforming to whoever you believe has the best information", true);
            questions.Add(question6);

            Question question7 = new Question("83% of participants in MIlgrams shock Experiment went up to the highest voltage of 450V", false);
            questions.Add(question7);

            Question question8 = new Question("A null hypothesis is a hypothesis that states theres no difference", true); 
            questions.Add(question8);

            Question question9 = new Question("Short term memory lasts 2 days ", false);
            questions.Add(question9);

            

        }
    }
}
