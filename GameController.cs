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
        private System.Windows.Forms.Button btnA, btnB, btnC, btnD;
        private List<Questions> questions;
        private QuestionService questionService;
        private int round;

        public GameController(object question, int round, int level, int cash, object btnA, object btnB, object btnC, object btnD)
        {
            this.lableQuestion = (Label)question;
            this.lableQuestion.Text = "Dies ist ein Test";
            this.level = level;
            this.round = round;
            this.cash = cash;
            this.btnA = (Button) btnA;
            this.btnB = (Button) btnB;
            this.btnC = (Button) btnC;
            this.btnD = (Button) btnD;

            this.questionService = new QuestionService();
            this.questions = new List<Questions>();
            this.questions = this.questionService.GetQuestions();
            this.lableQuestion.Text = this.questions[round].Question.ToString();



            //aktuallisierung von allem anderem
        }

        //Erstelle funktionen um zufällige fragen zu generieren und wenn alles funktioniert auch die antwort möglichkeiten umsortieren.

    }
}
