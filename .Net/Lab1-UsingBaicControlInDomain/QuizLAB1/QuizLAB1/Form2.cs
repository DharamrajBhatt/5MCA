using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizLAB1
{
    public partial class Form2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form2()
        {
            InitializeComponent();


            AskQuestion(questionNumber);

            totalQuestions = 8;
        }

       

        public void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);

            }

            questionNumber++;
            AskQuestion(questionNumber);

        }

        private void AskQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.PV_sindhu;

                    lblQuestion.Text = "Who is she , who won silver in Rio(2016) and bronze medal in tokyo(2021) olympic and becomes only womens to have two medals in olympics?";

                    button1.Text = "PV Sindhu";
                    button2.Text = "Saina Nehwal";
                    button3.Text = "Jwalla Gutta";
                    button4.Text = "Ashwini Ponnappa";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Bhavani_devi;

                    lblQuestion.Text = "who is she, first indian to represent india in Sabre Fencer in Olympic(Tokyo2021)?";

                    button1.Text = "Navneet Kaur";
                    button2.Text = "Bhavani Devi";
                    button3.Text = "Vandana katariya";
                    button4.Text = "Dutee Chand";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.rani;

                    lblQuestion.Text = "Who is she, who becames the first women hocky team caption to take her team in Olympic Semifinal";

                    button1.Text = "Vandana Katariya";
                    button2.Text = "Gurjit Kaur";
                    button3.Text = "Navneet Kaur";
                    button4.Text = "Rani Rampal";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.mirabai;

                    lblQuestion.Text = "who is she, she won the silver medal for India in weightlifting in this Olympic(Tokyo 2021)?";

                    button1.Text = "Mirabai Chanu";
                    button2.Text = "Karnam Malleshwari";
                    button3.Text = "Nikki Pradhan";
                    button4.Text = "Deepika kumari";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.manika_batra;

                    lblQuestion.Text = "Who is she, the Rising star of Indian women Table Tannis?";

                    button1.Text = "S. mukharjee";
                    button2.Text = "Ankita Das";
                    button3.Text = "Manika Batra";
                    button4.Text = "Neha Agarwal";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Deepika_kumari;

                    lblQuestion.Text = "Who is she, she is currently the world no 1 women Archer and represented India in Olympic in archary?";

                    button1.Text = "Marry com";
                    button2.Text = "Deepika kumari";
                    button3.Text = "s. mukharjee";
                    button4.Text = "Karnam maleshwari";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.kamaljeet;

                    lblQuestion.Text = "Who is she, she is first women to breach the 65mtr barrier in discuss throw and currently secured the 6th position in olympic discuss throw final in tokyo?";

                    button1.Text = "P.T Usha";
                    button2.Text = "sakshi malik";
                    button3.Text = "Manu Bhaker";
                    button4.Text = "Kamalpreet Kaur";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.lovlina;

                    lblQuestion.Text = "who is she, the women boxer who already secured bronze medal and may get silver or Gold if she wins semifinal in Tokyo2021?";

                    button1.Text = "MC Marry Com";
                    button2.Text = "Hima Das";
                    button3.Text = "Lovlina Borgohain";
                    button4.Text = "Saniya Mirza";

                    correctAnswer = 3;

                    break;




            }



        }
}
}
