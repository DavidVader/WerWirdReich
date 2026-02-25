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
            gameController.UpdateGameData(labelQuestion, labelCash, labelLevel, btnA, btnB, btnC, btnD);
        }




        private void btnClickController(object sender, EventArgs e)
        {
            gameController.CheckAnswer(sender, this);

            NeueFrage(); // ← HIER hinzufügen!

            gameController.UpdateGameData(labelQuestion, labelCash, labelLevel, btnA, btnB, btnC, btnD);
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        private void btnJoker1_Click(object sender, EventArgs e)
        {

            if (jokerAktiviert)
                return;

            // Stelle sicher, dass die richtige Antwort gesetzt ist
            int richtigeIndex = gameController.CurrentQuestion.RightAnswer;
            richtigeAntwortText = antwortButtons[richtigeIndex].Text;

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

        public void checkJokerBox(bool dome)
        {
            if (!dome)
            {
                btnJoker1.Visible = false;
                btnJoker2.Visible = false;
            }
            else
            {
                btnJoker1.Visible = true;
                btnJoker2.Visible = true;
            }
        }


        private void btnJoker2_Click(object sender, EventArgs e)
        {
            // Richtigen Index holen
            int richtigeIndex = gameController.CurrentCorrectIndex;

            // Liste aller falschen Antworten erstellen
            var falscheAntworten = antwortButtons
                .Where((button, index) => index != richtigeIndex && button.Visible)
                .ToList();

            // Sicherheitscheck (falls schon alles ausgeblendet wurde)
            if (falscheAntworten.Count == 0)
                return;

            // Eine falsche zufällig auswählen
            Button auszublenden = falscheAntworten[rnd.Next(falscheAntworten.Count)];

            // Ausblenden
            auszublenden.Enabled = false;
            auszublenden.Visible = false;

            // Joker deaktivieren (nur 1x nutzbar)
            btnJoker2.Enabled = false;
        }
    }
}
