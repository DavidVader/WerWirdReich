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

        public GameController(object lableQuestion)
        {
            this.lableQuestion = (Label)lableQuestion;
            this.lableQuestion.Text = "Dies ist ein Test";
            //aktuallisierung von allem anderem
        }

        //Erstelle funktionen um zufällige fragen zu generieren und wenn alles funktioniert auch die antwort möglichkeiten umsortieren.

    }
}
