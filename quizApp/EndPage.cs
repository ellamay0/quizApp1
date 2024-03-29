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

    public partial class EndPage : Form
    {
        Quiz quiz;
        public EndPage(Quiz quiz)
        {
            this.quiz = quiz;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeScreenBtn_Click(object sender, EventArgs e)
        {
            QuizEntryPage form = new QuizEntryPage();
            form.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EndPage_Load(object sender, EventArgs e)
        {
            score.Text = ""+quiz.Score;
            foreach(Question wrongQ in quiz.wrongquestions)
            {
                incorrectAnswers.Text += wrongQ.QuestionText+",   ";

            }
        }
    }
}
