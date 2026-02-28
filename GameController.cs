using WerWirdReich.Models;
using WerWirdReich.Services;


namespace WerWirdReich
{
    class GameController
    {
        private QuestionService questionService;
        private Label lableQuestion, labelPlayer;
        private List<Label> labelRounds;
        private List<Button> antwortButtons;
        public List<Questions> questions;
        private int[] cash = { 50, 100, 500, 1000, 5000, 10000, 50000, 100000, 500000, 1000000 };
        private int round = 0;
        private string playerName = FormCreateGame.playerName;
        public bool GameOver { get; private set; } = false;

        public GameController()
        {
            MusicService.StartMusic();
        }

        public void UpdateGameData(object question, List<Label> lRounds, object lPlayer, List<Button> antworten)
        {
            if (this.questions == null) GenerateQuestions();

            this.lableQuestion = (Label)question;
            this.labelPlayer = (Label)lPlayer;
            this.labelRounds = lRounds;
            this.antwortButtons = antworten;

            this.labelPlayer.Text = this.playerName;

            LoadQuestion(round);
        }

        public void LoadNextQuestion()
        {
            if (round < 10)
            {
                LoadQuestion(round);
            }
        }

        private void LoadQuestion(int roundIndex)
        {
            if (roundIndex < questions.Count)
            {
                this.lableQuestion.Text = questions[roundIndex].Question.ToString();

                for (int i = 0; i < 4; i++)
                {
                    antwortButtons[i].Text = questions[roundIndex].Answers[i].ToString();
                    antwortButtons[i].Visible = true;
                    antwortButtons[i].Enabled = true;
                }
                for (int i = 0; i < labelRounds.Count; i++)
                {
                    labelRounds[i].Font = new Font(labelRounds[i].Font, i == roundIndex ? FontStyle.Bold : FontStyle.Regular);
                }
            }
        }

        public void CheckAnswer(object sender, Form currentForm)
        {
            Button clickedButton = (Button)sender;
            int userAnswer = antwortButtons.IndexOf(clickedButton);

            if (questions[round].RightAnswer != userAnswer)
            {
                var player = PlayerService.GetPlayer(this.playerName);
                player.AmountOfPlaythrough++;
                player.HighScore = round > 0 ? Math.Max(player.HighScore, cash[round - 1]) : player.HighScore;
                PlayerService.EditPlayer(this.playerName, player);

                MusicService.StopMusic();
                SoundService.ButtonSounds.Wrong();

                MessageBox.Show("Sie haben verloren!");
                GameOver = true;
                FormMenu menu = new FormMenu();
                menu.Show();
                currentForm.Hide();
            }
            else
            {
                this.labelRounds[round].BackColor = Color.Green;

                if (round == 9)
                {
                    var player = PlayerService.GetPlayer(this.playerName);
                    player.TotalMoney += 1000000;
                    player.AmountOfPlaythrough++;
                    player.HighScore = 1000000;
                    PlayerService.EditPlayer(this.playerName, player);

                    MessageBox.Show("Sie haben 1.000.000 Mark gewonnen!");
                    GameOver = true;
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    currentForm.Hide();
                }
                else
                {
                    round++;
                }
            }
        }

        public Questions CurrentQuestion
        {
            get { return questions[round]; }
        }

        public int CurrentCorrectIndex
        {
            get { return questions[round].RightAnswer; }
        }

        private void GenerateQuestions()
        {
            this.questionService = new QuestionService();
            this.questions = this.questionService.GetQuestions();
        }
    }
}
