using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WerWirdReich.Models;
using WerWirdReich.Services;

namespace WerWirdReich
{
    class GameController
    {
        private System.Windows.Forms.Label lableQuestion;
        private Random random;
        private Player player;
        private int cash;
        private System.Windows.Forms.Button btnSender, btnA, btnB, btnC, btnD;
        public List<Questions> questions;
        private QuestionService questionService;
        private int round;
        public GameController() { }

        public void UpdateGameData(object question, object btnA, object btnB, object btnC, object btnD)
        {
            if (this.questions == null) GenerateQuestions();

            this.lableQuestion = (Label)question;
            this.btnA = (Button)btnA;
            this.btnB = (Button)btnB;
            this.btnC = (Button)btnC;
            this.btnD = (Button)btnD;

            this.lableQuestion.Text = this.questions[this.round].Question.ToString();

            this.btnA.Text = this.questions[this.round].Answers[0].ToString();
            this.btnB.Text = this.questions[this.round].Answers[1].ToString();
            this.btnC.Text = this.questions[this.round].Answers[2].ToString();
            this.btnD.Text = this.questions[this.round].Answers[3].ToString();

            round++;
        }

        public void CheckAnswer(object sender)
        {
            Button clickedButton = (Button)sender;

            int userAnswer = 0;
            if (clickedButton == btnA) userAnswer = 0;
            else if (clickedButton == btnB) userAnswer = 1;
            else if (clickedButton == btnC) userAnswer = 2;
            else if (clickedButton == btnD) userAnswer = 3;

            if (questions[round - 1].RightAnswer != userAnswer)
            {
                MessageBox.Show("Sie haben Verloren...");
                GenerateQuestions();
                round = 0;
            }
            else
            {
                cash += 100 * round;
            }
        }


        private void GenerateQuestions()
        {
            this.questionService = new QuestionService();
            this.questions = new List<Questions>();
            this.questions = this.questionService.GetQuestions();
        }
    }
}
