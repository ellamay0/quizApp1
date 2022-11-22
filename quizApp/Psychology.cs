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
    public partial class Psychology : Form
    {
        public PsychologyQuiz quiz;
        int questionNum = 0;
        public Psychology()
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            questionBox.Text = quiz.Questions[questionNum].QuestionText;
        }

        private void trueBtn_Click(object sender, EventArgs e)
        {
            if (quiz.Questions[questionNum].Answer == true)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.Questions[questionNum + 1].QuestionText;
        }

        private void falseBtn_Click(object sender, EventArgs e)
        {
            if (quiz.Questions[questionNum].Answer == false)
            {
                quiz.AddOneToScore();
            }
            questionBox.Text = quiz.Questions[questionNum + 1].QuestionText;
        }

        private void finishQuiz_Click(object sender, EventArgs e)
        {
            EndPage form = new EndPage();
            form.Show();
            this.Hide();
        }
    }
}
