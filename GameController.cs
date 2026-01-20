using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerWirdReich
{
    public class Player()
    {
        public string Name { get; set; }
        public int HighScore { get; set; }
        public int AmountOfPlaythrough { get; set; }
        public int TotalCash { get; set; }
    }
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
        }
    }
}
