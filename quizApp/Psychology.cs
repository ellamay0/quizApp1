using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizApp
{
    public partial class Psychology : Form

    {
        public PsychologyQuiz quiz;
        int questionNum = 0;
        public Psychology(PsychologyQuiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Psychology_Load(object sender, EventArgs e)
        {
            questionBox.Text = quiz.questions[questionNum].QuestionText;
        }


        private void trueBtn_Click(object sender, EventArgs e)
        {
            if (questionNum + 1 >= quiz.questions.Count) //make a function to optimise 
            {
                EndPage form = new EndPage();
                form.Show();
                this.Hide();
            }
            else
            {
                if (quiz.questions[questionNum].Answer == true)
                {
                    quiz.AddOneToScore();
                }
                questionNum = questionNum + 1;
                questionBox.Text = quiz.questions[questionNum].QuestionText;
            }
        }

        private void falseBtn_Click(object sender, EventArgs e)
        {
            if (questionNum + 1 >= quiz.questions.Count)
            {
                EndPage form = new EndPage();
                form.Show();
                this.Hide();
            }
            else
            {
                if (quiz.questions[questionNum].Answer == false)
                {
                    quiz.AddOneToScore();
                }
                questionNum = questionNum + 1;

                questionBox.Text = quiz.questions[questionNum].QuestionText;
            }
        }
    }
}
