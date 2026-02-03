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
        GameController meinSpiel;
        private int round = 0;

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;

            //Erhalte / Setze ein: Daten von GameControl
        }

        private void btnClickController(object sender, EventArgs e)
        {
            if (sender.Equals(btnA))
            {
                meinSpiel = new GameController(labelQuestion, round, 1000000, sender);
                round++;
            }

            if (sender.Equals(btnB))
            {
                meinSpiel = new GameController(labelQuestion, round, 1000000, sender);
                round++;
            }

            if (sender.Equals(btnC))
            {
                meinSpiel = new GameController(labelQuestion, round, 1000000, sender);
                round++;
            }

            if (sender.Equals(btnD))
            {
                meinSpiel = new GameController(labelQuestion, round, 1000000, sender);
                round++;
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
