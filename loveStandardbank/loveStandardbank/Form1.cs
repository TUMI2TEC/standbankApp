using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loveStandardbank
{
    public partial class Form1 : Form
    {
        private Random random;
        private int num1;
        private int num2;
        private int answer;
        private int num3;
        private int num4;
        private int score;
        private int totalQuestions;
        private int length;
		private int count;



        public Form1()
        {
            InitializeComponent();
            random = new Random();
            score = 0;
            totalQuestions = 0;
            length = 10;
			count = 0;

        }

		private void Form1_Load(object sender, EventArgs e)
		{
			GenerateQuestion();
		}


		private void GenerateQuestion() //function for generating number and quetions
        {
			for (count= 0; count <= length; count++) //for-loop for monitoring the numer of question
			{

				num1 = random.Next(1, 51); // Generates a number between 1 and 50
				num2 = random.Next(1, 51);

				//randomisation for multipucation

				num3 = random.Next(1, 13);  // Generates a number between 1 and 12
				num4 = random.Next(1, 13);

				int operation = random.Next(0, 4); //randomizing operators

				switch (operation)  // using switch case method to choose the equations 
				{
					case 0:
						answer = num1 + num2;
						questions.Text = $"{num1} + {num2} =";
						break;
					case 1:
						answer = num1 - num2;
						questions.Text = $"{num1} - {num2} =";
						break;
					case 2:

						answer = num1 * num2;
						questions.Text = $"{num3} * {num4} =";

						break;
					case 3:
						answer = num1 / num2;
						questions.Text = $"{num1} / {num2} =";
						break;
				}


				// focusing the cursor 

				userAnswer.Text = "";
				userAnswer.Focus();
			}
         }

        private void answerBtn_Click(object sender, EventArgs e)
        {
			// it checks the answer
            if (int.TryParse(userAnswer.Text, out int userResponse))
            {
                totalQuestions++;
                if (userResponse == answer)
                {
                    score++;
                    MessageBox.Show("Correct answer!");
                }
                else
                {
                    MessageBox.Show($"Wrong answer! The correct answer is {answer}.");


                }
                GenerateQuestion();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }

			if (totalQuestions==length)
			{
				MessageBox.Show($"You have Scored : {score}/{totalQuestions}");
				answerBtn.Enabled = false;
				questions.Enabled = false;
				userAnswer.Enabled = false;


			}

        }

        

        private void exitBtn_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

		private void restartBtn_Click(object sender, EventArgs e)
		{
			answerBtn.Enabled = true;
			questions.Enabled = true;
			userAnswer.Enabled = true;
			GenerateQuestion();

		}
	}

    
}   
