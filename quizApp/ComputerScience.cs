﻿using System;
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
    public partial class ComputerScience : Form
    {
        public ComputerScienceQuiz quiz;
        int questionNum = 0;
        public ComputerScience(ComputerScienceQuiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            questionBox.Text = quiz.questions[questionNum].QuestionText;
        }

        private void trueBtn_Click(object sender, EventArgs e)
        {
            if (quiz.questions[questionNum].Answer == true)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.questions[questionNum + 1].QuestionText;
            questionNum = questionNum + 1;
        }

       
        private void falseBtn_Click(object sender, EventArgs e)
        {
            if (quiz.questions[questionNum].Answer == false)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.questions[questionNum + 1].QuestionText;
            questionNum = questionNum + 1;
        }

        private void finishQuizBtn_Click(object sender, EventArgs e)
        {
            EndPage form = new EndPage();
            form.Show();
            this.Hide();
        }

    }
}
