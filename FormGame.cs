using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            meinSpiel = new GameController(labelQuestion);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            //Sende Ergebniss 0 an GameControl.
            //Update Daten (label, button, ...)
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
