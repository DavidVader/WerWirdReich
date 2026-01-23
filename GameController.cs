using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WerWirdReich.Models;

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

        public GameController(object question, int level, int cash, object btnA, object btnB, object btnC, object btnD)
        {
            this.lableQuestion = (Label)question;
            this.lableQuestion.Text = "Dies ist ein Test";
            this.level = level;
            this.cash = cash;
            this.btnA = (Button) btnA;
            this.btnB = (Button) btnB;
            this.btnC = (Button) btnC;
            this.btnD = (Button) btnD;

            //aktuallisierung von allem anderem
        }

        //Erstelle funktionen um zufällige fragen zu generieren und wenn alles funktioniert auch die antwort möglichkeiten umsortieren.

    }
}
