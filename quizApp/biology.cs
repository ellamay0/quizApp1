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
            questionBox.Text = quiz.Questions[questionNum].QuestionText;
        }

        private void trueButton_Click(object sender, EventArgs e)
        {
            if(quiz.Questions[questionNum].Answer == true)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.Questions[questionNum +1].QuestionText;
        }

        private void falseButton_Click(object sender, EventArgs e)
        {
            if(quiz.Questions[questionNum].Answer == false)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.Questions[questionNum + 1].QuestionText;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndPage form = new EndPage();
            form.Show();
            this.Hide();
        }
    }
}
