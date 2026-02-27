using System.Data;


namespace WerWirdReich
{
    public partial class FormGame : Form
    {
        private GameController gameController;
        private FormOption fOption;
        private int round = 0;
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
            gameController.UpdateGameData(labelQuestion, labelRounds, labelName, btnA, btnB, btnC, btnD);
        }

        private void btnClickController(object sender, EventArgs e)
        {
            gameController.CheckAnswer(sender, this);
            NewQuestion();
            gameController.UpdateGameData(labelQuestion, labelRounds, labelName, btnA, btnB, btnC, btnD);
        }

        private void btnJoker1_Click(object sender, EventArgs e)
        {
            if (jokerAktiviert) return;

            // Setzt Richtige Antwort
            int richtigeIndex = gameController.CurrentQuestion.RightAnswer;
            richtigeAntwortText = antwortButtons[richtigeIndex].Text;

            // Zwei falsche Antworten auswählen
            var falscheAntworten = antwortButtons
                .Where(b => b.Text != richtigeAntwortText)
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

        private void NewQuestion()
        {
            foreach (var btn in antwortButtons)
            {
                btn.Visible = true;
                btn.Enabled = true;
            }

            if (!jokerAktiviert) btnJoker1.Enabled = true;

            // Richtige Antwort für die neue Runde setzen
            richtigeAntwortText = gameController.questions[round].RightAnswer.ToString();
        }

        private void btnJoker2_Click(object sender, EventArgs e)
        {
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
