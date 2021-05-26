using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Jatek
{
    public partial class Quiz : Form
    {
        // Variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;






        public Quiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestion = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestion)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);


                MessageBox.Show(
                    "Quiz játék vége!" + Environment.NewLine + 
                    "Volt " + score + " helyes válaszod" + Environment.NewLine +
                    "A százalékod : " + percentage + "%" + Environment.NewLine +
                    "Kattints az OK-ra az újra kezdéshez"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Budapest;

                    lblQuestion.Text = "Melyik város látható a képen?";

                    button1.Text = "Párizs";
                    button2.Text = "Budapest";
                    button3.Text = "Barcelona";
                    button4.Text = "Kapuvár";

                    correctAnswer = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Pápa;

                    lblQuestion.Text = "Melyik pápa látható a képen?";

                    button1.Text = "Ferenc pápa";
                    button2.Text = "János pápa";
                    button3.Text = "Benedek pápa";
                    button4.Text = "Celesztin pápa";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Badacsony;

                    lblQuestion.Text = "Melyik hegy látható a képen?";

                    button1.Text = "Badacsony";
                    button2.Text = "Mátra";
                    button3.Text = "Kékes";
                    button4.Text = "Pilis";

                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Hofi;

                    lblQuestion.Text = "Mikor született a képen látható Hofi Géza?";

                    button1.Text = "1953";
                    button2.Text = "1965";
                    button3.Text = "1944";
                    button4.Text = "1936";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.HeimPal;

                    lblQuestion.Text = "Melyik kerületben található a Heim Pál kórház?";

                    button1.Text = "VIII.";
                    button2.Text = "IX.";
                    button3.Text = "XIII.";
                    button4.Text = "VII.";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Bíró_László_József;

                    lblQuestion.Text = "Mit talált fel Bíró László József?";

                    button1.Text = "Gyufa";
                    button2.Text = "rubikkocka";
                    button3.Text = "Dinamo";
                    button4.Text = "golyóstoll";

                    correctAnswer = 4;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.MezgaGeza;

                    lblQuestion.Text = "Ki nem szerepel a Mézga Géza című rajzfilmsorozatban?";

                    button1.Text = "Blöki";
                    button2.Text = "Aladár";
                    button3.Text = "MZ/X";
                    button4.Text = "Nielsen";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.FeketeIstvan;

                    lblQuestion.Text = "Melyik nem Fekete István regénye?";

                    button1.Text = "Zsellérek";
                    button2.Text = "A Pál utcai fiúk";
                    button3.Text = "Hajnal Badányban";
                    button4.Text = "Vuk";
                    
                    correctAnswer = 2;

                    break;


            }


        }
    }
}
