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

            Question question = new Question("Natural selection is survival of the fittest", true);
            Questions.Append(question);

            Question question1 = new Question("A cell membrane has a phospholipid trilayer", false);
            Questions.Append(question);

            Question question2 = new Question("Products of photosynthesis are carbon and water", false);
            Questions.Append(question);

            Question question3 = new Question("Vaccines contain dead or weakned pathogens", true);
            Questions.Append(question);

            Question question4= new Question("The cardiac cycle has 3 stages atrail systole, ventricular systole  and diastole", true);
            Questions.Append(question);

            Question question5 = new Question("Immobilized enzymes are free to move around", false);
            Questions.Append(question);

            Question question6 = new Question("The cardiac cycle has 3 stages atrail systole, ventricular systole  and diastole", true);
            Questions.Append(question);

            Question question7 = new Question("Fish have gill lamelle which aid digestion", false);
            Questions.Append(question);

            Question question8 = new Question("Plant cells and bacterium have a nuclues", false);
            Questions.Append(question);

            Question question9 = new Question("The emulsion test is how you test for the presence of lipids in a smaple", true);
            Questions.Append(question);
 
        }

    }
}
