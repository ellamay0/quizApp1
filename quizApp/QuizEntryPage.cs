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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void biologyBtn_Click(object sender, EventArgs e)
        {
            biology form = new biology();
            form.Show();
            this.Hide();
        }

        private void psychologyBtn_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void computerBtn_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void returnTitleBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
