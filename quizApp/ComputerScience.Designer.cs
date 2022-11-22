
namespace quizApp
{
    partial class ComputerScience
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
            this.finishQuizBtn = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.trueBtn = new System.Windows.Forms.Button();
            this.falseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finishQuizBtn
            // 
            this.finishQuizBtn.BackColor = System.Drawing.SystemColors.Window;
            this.finishQuizBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishQuizBtn.Location = new System.Drawing.Point(656, 402);
            this.finishQuizBtn.Name = "finishQuizBtn";
            this.finishQuizBtn.Size = new System.Drawing.Size(132, 36);
            this.finishQuizBtn.TabIndex = 2;
            this.finishQuizBtn.Text = "Finish Quiz!";
            this.finishQuizBtn.UseVisualStyleBackColor = false;
            this.finishQuizBtn.Click += new System.EventHandler(this.finishQuizBtn_Click);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(220, 84);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(332, 127);
            this.questionBox.TabIndex = 3;
            this.questionBox.Text = "";
            // 
            // trueBtn
            // 
            this.trueBtn.BackColor = System.Drawing.SystemColors.Window;
            this.trueBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueBtn.Location = new System.Drawing.Point(180, 255);
            this.trueBtn.Name = "trueBtn";
            this.trueBtn.Size = new System.Drawing.Size(100, 36);
            this.trueBtn.TabIndex = 4;
            this.trueBtn.Text = "True";
            this.trueBtn.UseVisualStyleBackColor = false;
            this.trueBtn.Click += new System.EventHandler(this.trueBtn_Click);
            // 
            // falseBtn
            // 
            this.falseBtn.BackColor = System.Drawing.SystemColors.Window;
            this.falseBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseBtn.Location = new System.Drawing.Point(499, 255);
            this.falseBtn.Name = "falseBtn";
            this.falseBtn.Size = new System.Drawing.Size(100, 37);
            this.falseBtn.TabIndex = 5;
            this.falseBtn.Text = "False";
            this.falseBtn.UseVisualStyleBackColor = false;
            this.falseBtn.Click += new System.EventHandler(this.falseBtn_Click);
            // 
            // ComputerScience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.falseBtn);
            this.Controls.Add(this.trueBtn);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.finishQuizBtn);
            this.Name = "ComputerScience";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button finishQuizBtn;
        private System.Windows.Forms.RichTextBox questionBox;
        private System.Windows.Forms.Button trueBtn;
        private System.Windows.Forms.Button falseBtn;
    }
}