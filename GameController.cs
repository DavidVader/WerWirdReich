using WerWirdReich.Models;
using WerWirdReich.Services;


namespace WerWirdReich
{
    class GameController
    {
        private System.Windows.Forms.Label lableQuestion, labelPlayer;
        private List<System.Windows.Forms.Label> labelRounds;
        private int[] cash = { 50, 100, 500, 1000, 5000, 10000, 50000, 100000, 500000, 1000000 };
        private System.Windows.Forms.Button btnA, btnB, btnC, btnD;
        public List<Questions> questions;
        private QuestionService questionService;
        private int round;
        private string playerName = FormCreateGame.playerName;

        public GameController() { }

        public void UpdateGameData(object question, List<Label> lRounds, object lPlayer, object btnA, object btnB, object btnC, object btnD)
        {
            if (this.questions == null || round >= 10)
            {
                GenerateQuestions();
                round = 0;
            }

            this.lableQuestion = (Label)question;
            this.labelRounds = lRounds;
            this.labelPlayer = (Label)lPlayer;
            this.btnA = (Button)btnA;
            this.btnB = (Button)btnB;
            this.btnC = (Button)btnC;
            this.btnD = (Button)btnD;

            this.labelPlayer.Text = this.playerName;
            this.lableQuestion.Text = this.questions?[this.round].Question.ToString();
            this.labelRounds[round].Font = new Font(this.labelRounds[round].Font, FontStyle.Bold);

            this.btnA.Text = this.questions?[this.round].Answers[0].ToString();
            this.btnB.Text = this.questions?[this.round].Answers[1].ToString();
            this.btnC.Text = this.questions?[this.round].Answers[2].ToString();
            this.btnD.Text = this.questions?[this.round].Answers[3].ToString();

            //this.lableQuestion.Text = (this.questions?[this.round].RightAnswer + 1).ToString(); //Loesung

            round++;
        }

        public void CheckAnswer(object sender, Form currentForm)
        {
            Button clickedButton = (Button)sender;

            int userAnswer = 0;
            if (clickedButton == btnA) userAnswer = 0;
            else if (clickedButton == btnB) userAnswer = 1;
            else if (clickedButton == btnC) userAnswer = 2;
            else if (clickedButton == btnD) userAnswer = 3;

            if (questions[round - 1].RightAnswer != userAnswer)
            {
                var player = PlayerService.GetPlayer(this.playerName);
                player.AmountOfPlaythrough++;
                player.HighScore = player.HighScore <= cash[round - 1] ? cash[round - 1] : player.HighScore;
                PlayerService.EditPlayer(this.playerName, player);

                MessageBox.Show("Sie haben verloren!");
                FormMenu menu = new FormMenu();
                menu.Show();
                currentForm.Hide();
            }
            else
            {
                this.labelRounds[round - 1].BackColor = Color.Green;
                this.labelRounds[round - 1].Font = new Font(this.labelRounds[round - 1].Font, FontStyle.Regular);

                if (round == 10)
                {
                    var player = PlayerService.GetPlayer(this.playerName);
                    player.TotalMoney += 1000000;
                    player.AmountOfPlaythrough++;
                    player.HighScore = 1000000;
                    PlayerService.EditPlayer(this.playerName, player);

                    MessageBox.Show("Sie haben 1.000.000 Mark gewonnen!");
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    currentForm.Hide();
                }
            }
        }

        public Questions CurrentQuestion
        {
            get { return questions[round - 1]; }
        }

        public int CurrentCorrectIndex
        {
            get
            {
                return questions[round - 1].RightAnswer;
            }
        }


        private void GenerateQuestions()
        {
            this.questionService = new QuestionService();
            this.questions = new List<Questions>();
            this.questions = this.questionService.GetQuestions();
        }
    }
}
