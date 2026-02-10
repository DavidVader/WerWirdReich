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
        GameController meinSpiel;
        private int round = 0;

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;
            gameController = new GameController();
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);

            //Erhalte / Setze ein: Daten von GameControl
        }

        private void btnClickController(object sender, EventArgs e)
        {
            if (sender.Equals(btnA))
            {
                meinSpiel = new GameController(sender);
            }

            if (sender.Equals(btnB))
            {
                meinSpiel = new GameController(sender);
            }

            if (sender.Equals(btnC))
            {
                meinSpiel = new GameController(sender);
            }

            if (sender.Equals(btnD))
            {
                meinSpiel = new GameController(sender);
            }
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
