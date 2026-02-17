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
        private string richtigeAntwortText;


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

            NeueFrage(); // ← HIER hinzufügen!

            gameController.UpdateGameData(labelQuestion, btnA, btnB, btnC, btnD);
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        private void btnJoker1_Click(object sender, EventArgs e)
        {

            if (jokerAktiviert)
                return;

            // Stelle sicher, dass die richtige Antwort gesetzt ist
            if (string.IsNullOrEmpty(richtigeAntwortText))
                richtigeAntwortText = gameController.questions[round].RightAnswer.ToString();

            // Zwei falsche Antworten auswählen
            var falscheAntworten = antwortButtons
                .Where(b => b.Text != richtigeAntwortText) // nur falsche Antworten
                .OrderBy(x => rnd.Next())
                .Take(2)
                .ToList();

            foreach (var btn in falscheAntworten)
            {
                btn.Enabled = false;
                btn.Visible = false;
            }

            // Joker deaktivieren und ausgrauen
            jokerAktiviert = true;
            btnJoker1.Enabled = false;
            btnJoker1.BackColor = Color.Gray;
            btnJoker1.ForeColor = Color.White;
        }

        private void NeueFrage()
        {
            foreach (var btn in antwortButtons)
            {
                btn.Visible = true;
                btn.Enabled = true;
            }

            if (!jokerAktiviert)
                btnJoker1.Enabled = true;

            // Richtige Antwort für die neue Runde setzen
            richtigeAntwortText = gameController.questions[round].RightAnswer.ToString();
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
