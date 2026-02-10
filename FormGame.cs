using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WerWirdReich.Models;

namespace WerWirdReich
{
    public partial class FormGame : Form
    {
        private GameController gameController;
        private int round = 0;

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;
            gameController = new GameController();
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }

        private void btnClickController(object sender, EventArgs e)
        {
            gameController.CheckAnswer(sender);
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
