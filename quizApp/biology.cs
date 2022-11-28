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
            //add check if quiz question is out of array bounds 
            if(quiz.questions[questionNum].Answer == true)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.questions[questionNum +1].QuestionText; 
            questionNum = questionNum + 1;
        }

        
        private void falseButton_Click(object sender, EventArgs e) 
        {
            if(quiz.questions[questionNum].Answer == false)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.questions[questionNum + 1].QuestionText;
            questionNum = questionNum + 1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndPage form = new EndPage();
            form.Show();
            this.Hide();
        }
    }
}
