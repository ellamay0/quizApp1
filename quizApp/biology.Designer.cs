
namespace quizApp
{
    partial class biology
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
            this.trueButton = new System.Windows.Forms.Button();
            this.falseButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // trueButton
            // 
            this.trueButton.Location = new System.Drawing.Point(383, 248);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(75, 23);
            this.trueButton.TabIndex = 0;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            this.trueButton.Click += new System.EventHandler(this.trueButton_Click);
            // 
            // falseButton
            // 
            this.falseButton.Location = new System.Drawing.Point(193, 248);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(75, 23);
            this.falseButton.TabIndex = 1;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            this.falseButton.Click += new System.EventHandler(this.falseButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(236, 65);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(210, 148);
            this.questionBox.TabIndex = 2;
            this.questionBox.Text = "";
            // 
            // biology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.trueButton);
            this.Name = "biology";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.biology_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.Button falseButton;
        private System.Windows.Forms.RichTextBox questionBox;
    }
}