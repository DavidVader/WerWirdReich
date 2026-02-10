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
using System.Linq;


namespace WerWirdReich
{
    public partial class FormGame : Form
    {
        private GameController gameController;
        private int round = 0;

        private Button richtigeAntwort;
        private List<Button> antwortButtons;
        private Random rnd = new Random();
        private bool jokerAktiviert = false;

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;

            antwortButtons = new List<Button>
            {
                btnA,
                btnB,
                btnC,
                btnD
            };

            gameController = new GameController();
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }




        private void btnClickController(object sender, EventArgs e)
        {
            gameController.CheckAnswer(sender);
            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        private void btnJoker1_Click(object sender, EventArgs e)
        {
            // falsche Antworten ermitteln
            var falscheAntworten = antwortButtons
                .Where(b => b != richtigeAntwort)
                .OrderBy(x => rnd.Next())
                .Take(2);

            // ausblenden
            foreach (var btn in falscheAntworten)
            {
                btn.Enabled = false;
                btn.Visible = false; // oder nur Enabled=false
            }
            


        }

        private void btnJoker2_Click(object sender, EventArgs e)
        {
            var falscheAntworten = antwortButtons
        .Where(b => b != richtigeAntwort)
        .ToList();

            // eine falsche zufällig auswählen
            Button auszublenden = falscheAntworten[rnd.Next(falscheAntworten.Count)];

            // ausblenden oder deaktivieren
            auszublenden.Enabled = false;
            auszublenden.Visible = false;
        }

        private void btnZweitversuchJoker_Click(object sender, EventArgs e)
        {
            jokerAktiviert = true;
            MessageBox.Show("Joker aktiviert! Wähle eine beliebige Antwort, um weiterzumachen.");

            // Optional: alle Buttons aktiv lassen
            foreach (var btn in antwortButtons)
            {
                btn.Enabled = true;
            }

            btnZweitversuchJoker.Enabled = false; // Joker nur einmal pro Frage
        }
    }
}
