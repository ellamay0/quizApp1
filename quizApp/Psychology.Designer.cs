
namespace quizApp
{
    partial class Psychology
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
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.trueBtn = new System.Windows.Forms.Button();
            this.falseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(207, 73);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(415, 169);
            this.questionBox.TabIndex = 2;
            this.questionBox.Text = "";
            // 
            // trueBtn
            // 
            this.trueBtn.BackColor = System.Drawing.SystemColors.Window;
            this.trueBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueBtn.Location = new System.Drawing.Point(207, 273);
            this.trueBtn.Name = "trueBtn";
            this.trueBtn.Size = new System.Drawing.Size(120, 48);
            this.trueBtn.TabIndex = 3;
            this.trueBtn.Text = "True";
            this.trueBtn.UseVisualStyleBackColor = false;
            this.trueBtn.Click += new System.EventHandler(this.trueBtn_Click);
            // 
            // falseBtn
            // 
            this.falseBtn.BackColor = System.Drawing.SystemColors.Window;
            this.falseBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseBtn.Location = new System.Drawing.Point(502, 273);
            this.falseBtn.Name = "falseBtn";
            this.falseBtn.Size = new System.Drawing.Size(120, 48);
            this.falseBtn.TabIndex = 4;
            this.falseBtn.Text = "False";
            this.falseBtn.UseVisualStyleBackColor = false;
            this.falseBtn.Click += new System.EventHandler(this.falseBtn_Click);
            // 
            // Psychology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.falseBtn);
            this.Controls.Add(this.trueBtn);
            this.Controls.Add(this.questionBox);
            this.Name = "Psychology";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Psychology_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox questionBox;
        private System.Windows.Forms.Button trueBtn;
        private System.Windows.Forms.Button falseBtn;
    }
}