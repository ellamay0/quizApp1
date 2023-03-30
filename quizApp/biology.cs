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
    public partial class biology : Form 
    {
        public BiologyQuiz quiz;
        int questionNum = 0;
        public biology(BiologyQuiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void biology_Load(object sender, EventArgs e)
        {
            questionBox.Text = quiz.questions[questionNum].QuestionText;
        }

        private void trueButton_Click(object sender, EventArgs e)
        {
            if (questionNum + 1 >= quiz.questions.Count) //make a function to optimise 
            {
                EndPage form = new EndPage(quiz);
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


        private void falseButton_Click(object sender, EventArgs e) 
        {
            if(questionNum+1 >= quiz.questions.Count) 
            {
                EndPage form = new EndPage(quiz);
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

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
