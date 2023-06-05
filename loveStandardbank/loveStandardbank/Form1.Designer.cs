namespace loveStandardbank
{
    partial class Form1
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
			this.answerBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.restartBtn = new System.Windows.Forms.Button();
			this.questions = new System.Windows.Forms.TextBox();
			this.userAnswer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// answerBtn
			// 
			this.answerBtn.BackColor = System.Drawing.Color.Lime;
			this.answerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.answerBtn.Location = new System.Drawing.Point(379, 68);
			this.answerBtn.Name = "answerBtn";
			this.answerBtn.Size = new System.Drawing.Size(124, 35);
			this.answerBtn.TabIndex = 0;
			this.answerBtn.Text = "ANSWER";
			this.answerBtn.UseVisualStyleBackColor = false;
			this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.BackColor = System.Drawing.Color.Red;
			this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.Location = new System.Drawing.Point(379, 227);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(124, 35);
			this.exitBtn.TabIndex = 1;
			this.exitBtn.Text = "EXIT";
			this.exitBtn.UseVisualStyleBackColor = false;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// restartBtn
			// 
			this.restartBtn.BackColor = System.Drawing.Color.Yellow;
			this.restartBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restartBtn.Location = new System.Drawing.Point(379, 146);
			this.restartBtn.Name = "restartBtn";
			this.restartBtn.Size = new System.Drawing.Size(124, 35);
			this.restartBtn.TabIndex = 2;
			this.restartBtn.Text = "RESTART";
			this.restartBtn.UseVisualStyleBackColor = false;
			this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
			// 
			// questions
			// 
			this.questions.Location = new System.Drawing.Point(106, 68);
			this.questions.Name = "questions";
			this.questions.Size = new System.Drawing.Size(137, 20);
			this.questions.TabIndex = 3;
			// 
			// userAnswer
			// 
			this.userAnswer.Location = new System.Drawing.Point(106, 126);
			this.userAnswer.Name = "userAnswer";
			this.userAnswer.Size = new System.Drawing.Size(137, 20);
			this.userAnswer.TabIndex = 4;
			// 
			// Form1
			// 
			this.AcceptButton = this.answerBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitBtn;
			this.ClientSize = new System.Drawing.Size(637, 291);
			this.Controls.Add(this.userAnswer);
			this.Controls.Add(this.questions);
			this.Controls.Add(this.restartBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.answerBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.TextBox questions;
        private System.Windows.Forms.TextBox userAnswer;
    }
}

