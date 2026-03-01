using System.Data;
using WerWirdReich.Services;


namespace WerWirdReich
{
    public partial class FormGame : Form
    {
        private GameController gameController;
        private FormOption fOption;
        private List<Button> antwortButtons;
        private Random rnd = new Random();
        private bool jokerAktiviert = false;
        private string richtigeAntwortText;
        private List<Label> labelRounds;

        public FormGame()
        {
            InitializeComponent();
            FormClosing += Game_FormClosing;

            antwortButtons = new List<Button> { btnA, btnB, btnC, btnD };
            labelRounds = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };

            gameController = new GameController();
            gameController.UpdateGameData(labelQuestion, labelRounds, labelName, antwortButtons);
        }

        private void btnClickController(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Click();

            gameController.CheckAnswer(sender, this);

            if (!gameController.GameOver)
            {
                gameController.LoadNextQuestion();
            }
        }

        private void btnJoker1_Click(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Joker();

            if (jokerAktiviert) return;

            // Setzt Richtige Antwort
            int richtigeIndex = gameController.CurrentCorrectIndex;
            richtigeAntwortText = antwortButtons[richtigeIndex].Text;

            // Zwei falsche Antworten auswählen
            var falscheAntworten = antwortButtons
                .Where(b => b.Text != richtigeAntwortText && b.Visible)
                .OrderBy(x => rnd.Next())
                .Take(2)
                .ToList();

            foreach (var btn in falscheAntworten)
            {
                btn.Enabled = false;
                btn.Visible = false;
            }

            jokerAktiviert = true;
            btnJoker1.Enabled = false;
            btnJoker1.BackColor = Color.Gray;
            btnJoker1.ForeColor = Color.White;
        }

        private void btnJoker2_Click(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Joker();

            int richtigeIndex = gameController.CurrentCorrectIndex;

            // Liste aller falschen Antworten erstellen
            var falscheAntworten = antwortButtons
                .Where((button, index) => index != richtigeIndex && button.Visible)
                .ToList();

            // Sicherheitscheck (falls schon alles ausgeblendet wurde)
            if (falscheAntworten.Count == 0) return;

            // Eine falsche zufällig auswählen
            Button auszublenden = falscheAntworten[rnd.Next(falscheAntworten.Count)];
            auszublenden.Enabled = false;
            auszublenden.Visible = false;

            btnJoker2.Enabled = false;
            btnJoker2.BackColor = Color.Gray;
            btnJoker2.ForeColor = Color.White;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Click();
            fOption = new FormOption();
            fOption.Show();
        }

        /*
         * This Function is closing the whole Application, 
         * since the main Form (Menu) is still running in the background...
         * THATS WHY WE COULD NOT START THE PROGRAM, since it already runs in the background...
         * 
         * ~ David
         */

        private void Game_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}