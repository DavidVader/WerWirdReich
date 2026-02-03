using System;
using System.Collections.Generic;
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
        private int level;
        private System.Windows.Forms.Label lableQuestion;
        private Random random;
        private Player player;
        private int cash;
        private System.Windows.Forms.Button btnSender;
        private List<Questions> questions;
        private QuestionService questionService;
        private int round;

        public GameController(object question, int round, int cash, object btnSender)
        {
            this.lableQuestion = (Label)question;
            this.round = round;
            this.cash = cash;
            this.btnSender = (Button)btnSender;

            this.questionService = new QuestionService();
            this.questions = new List<Questions>();
            this.questions = this.questionService.GetQuestions();
            if (round <= 3) level = 0;
            if (round > 3 && round <= 6) level = 1;
            if (round > 6) level = 2;
            this.lableQuestion.Text = this.questions[level].Question.ToString();

            if (this.btnSender.Name == "btnA")
            {
                this.btnSender.Text = this.questions[level].Answers[0].ToString();
            }

            if (this.btnSender.Name == "btnB")
            {
                this.btnSender.Text = this.questions[level].Answers[0].ToString();
            }

            if (this.btnSender.Name == "btnC")
            {
                this.btnSender.Text = this.questions[level].Answers[0].ToString();
            }

            if (this.btnSender.Name == "btnD")
            {
                this.btnSender.Text = this.questions[level].Answers[0].ToString();
            }


            //aktuallisierung von allem anderem
        }

        //Erstelle funktionen um zufällige fragen zu generieren und wenn alles funktioniert auch die antwort möglichkeiten umsortieren.

    }
}
