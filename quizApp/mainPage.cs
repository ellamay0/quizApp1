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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void titleStartBtn_Click(object sender, EventArgs e)
        {
            QuizEntryPage form = new QuizEntryPage();
            form.Show();
            this.Hide();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
