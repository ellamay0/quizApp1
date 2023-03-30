
namespace quizApp
{
    partial class EndPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeScreenBtn = new System.Windows.Forms.Button();
            this.incorrectAnswers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeScreenBtn
            // 
            this.homeScreenBtn.BackColor = System.Drawing.SystemColors.Window;
            this.homeScreenBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenBtn.Location = new System.Drawing.Point(300, 394);
            this.homeScreenBtn.Name = "homeScreenBtn";
            this.homeScreenBtn.Size = new System.Drawing.Size(194, 44);
            this.homeScreenBtn.TabIndex = 0;
            this.homeScreenBtn.Text = "Return to home screen";
            this.homeScreenBtn.UseVisualStyleBackColor = false;
            this.homeScreenBtn.Click += new System.EventHandler(this.homeScreenBtn_Click);
            // 
            // incorrectAnswers
            // 
            this.incorrectAnswers.Location = new System.Drawing.Point(65, 204);
            this.incorrectAnswers.Multiline = true;
            this.incorrectAnswers.Name = "incorrectAnswers";
            this.incorrectAnswers.Size = new System.Drawing.Size(661, 172);
            this.incorrectAnswers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "____________ End of quiz ____________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incorrect answers:";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(381, 120);
            this.score.Multiline = true;
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(138, 40);
            this.score.TabIndex = 4;
            this.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.score.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score";
            // 
            // EndPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incorrectAnswers);
            this.Controls.Add(this.homeScreenBtn);
            this.Name = "EndPage";
            this.Text = "EndPage";
            this.Load += new System.EventHandler(this.EndPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeScreenBtn;
        private System.Windows.Forms.TextBox incorrectAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Label label3;
    }
}