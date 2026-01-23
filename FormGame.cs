using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;

            //Erhalte / Setze ein: Daten von GameControl
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            //Sende Ergebniss 0 an GameControl.
            //Update Daten (label, button, ...)
            meinSpiel = new GameController(labelQuestion, 1, 1000000, btnA, btnB, btnC, btnD);
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            //Sende Ergebniss 1 an GameControl.
            //Update Daten (label, button, ...)
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            //Sende Ergebniss 2 an GameControl.
            //Update Daten (label, button, ...)
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            //Sende Ergebniss 3 an GameControl.
            //Update Daten (label, button, ...)
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
