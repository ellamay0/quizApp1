
namespace quizApp
{
    partial class QuizEntryPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.biologyBtn = new System.Windows.Forms.Button();
            this.psychologyBtn = new System.Windows.Forms.Button();
            this.computerBtn = new System.Windows.Forms.Button();
            this.returnTitleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "_____________ Quiz App _____________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click a subject to begin ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 296);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "graph??";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 352);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "              Your subjects";
            // 
            // biologyBtn
            // 
            this.biologyBtn.BackColor = System.Drawing.SystemColors.Window;
            this.biologyBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biologyBtn.Location = new System.Drawing.Point(87, 173);
            this.biologyBtn.Name = "biologyBtn";
            this.biologyBtn.Size = new System.Drawing.Size(222, 47);
            this.biologyBtn.TabIndex = 4;
            this.biologyBtn.Text = "Biology";
            this.biologyBtn.UseVisualStyleBackColor = false;
            this.biologyBtn.Click += new System.EventHandler(this.biologyBtn_Click);
            // 
            // psychologyBtn
            // 
            this.psychologyBtn.BackColor = System.Drawing.SystemColors.Window;
            this.psychologyBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psychologyBtn.Location = new System.Drawing.Point(87, 263);
            this.psychologyBtn.Name = "psychologyBtn";
            this.psychologyBtn.Size = new System.Drawing.Size(222, 47);
            this.psychologyBtn.TabIndex = 5;
            this.psychologyBtn.Text = "Psychology";
            this.psychologyBtn.UseVisualStyleBackColor = false;
            this.psychologyBtn.Click += new System.EventHandler(this.psychologyBtn_Click);
            // 
            // computerBtn
            // 
            this.computerBtn.BackColor = System.Drawing.SystemColors.Window;
            this.computerBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerBtn.Location = new System.Drawing.Point(87, 357);
            this.computerBtn.Name = "computerBtn";
            this.computerBtn.Size = new System.Drawing.Size(222, 47);
            this.computerBtn.TabIndex = 6;
            this.computerBtn.Text = "Computer science";
            this.computerBtn.UseVisualStyleBackColor = false;
            this.computerBtn.Click += new System.EventHandler(this.computerBtn_Click);
            // 
            // returnTitleBtn
            // 
            this.returnTitleBtn.BackColor = System.Drawing.SystemColors.Window;
            this.returnTitleBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTitleBtn.Location = new System.Drawing.Point(513, 398);
            this.returnTitleBtn.Name = "returnTitleBtn";
            this.returnTitleBtn.Size = new System.Drawing.Size(184, 40);
            this.returnTitleBtn.TabIndex = 7;
            this.returnTitleBtn.Text = "Return to title screen";
            this.returnTitleBtn.UseVisualStyleBackColor = false;
            this.returnTitleBtn.Click += new System.EventHandler(this.returnTitleBtn_Click);
            // 
            // QuizEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnTitleBtn);
            this.Controls.Add(this.computerBtn);
            this.Controls.Add(this.psychologyBtn);
            this.Controls.Add(this.biologyBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "QuizEntryPage";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button biologyBtn;
        private System.Windows.Forms.Button psychologyBtn;
        private System.Windows.Forms.Button computerBtn;
        private System.Windows.Forms.Button returnTitleBtn;
    }
}