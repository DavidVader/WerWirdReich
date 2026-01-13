using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerWirdReich
{
    class GameController
    {
        int level;
        private System.Windows.Forms.Label lableQuestion;
        public GameController(object lableQuestion)
        {
            this.lableQuestion = (Lable)lableQuestion;
            this.lableQuestion.Text = "Dies ist ein Test";
        }
    }
}
