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
    public partial class QuizEntryPage : Form
    {
        public QuizEntryPage()
        {
            InitializeComponent();
        }

        private void biologyBtn_Click(object sender, EventArgs e)
        {
            BiologyQuiz biology = new BiologyQuiz();
            biology.setupQuiz();
            biology form = new biology(biology);

            form.Show();
            this.Hide();
        }

        private void psychologyBtn_Click(object sender, EventArgs e)
        {
            PsychologyQuiz Psychology = new PsychologyQuiz();
            Psychology.setupQuiz();
            Psychology form = new Psychology(Psychology);

            form.Show();
            this.Hide();
        }

        private void computerBtn_Click(object sender, EventArgs e)
        {
            ComputerScienceQuiz ComputerScience = new ComputerScienceQuiz();
            ComputerScience.setupQuiz();
            ComputerScience form = new ComputerScience(ComputerScience);

            form.Show();
            this.Hide();
        }

        private void returnTitleBtn_Click(object sender, EventArgs e)
        {
            mainPage form = new mainPage();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
