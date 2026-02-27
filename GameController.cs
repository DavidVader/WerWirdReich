using WerWirdReich.Models;
using WerWirdReich.Services;


namespace WerWirdReich
{
    class GameController
    {
        private System.Windows.Forms.Label lableQuestion, labelMoney, labelRound, labelPlayer;
        private Random random;
        private Player player;
        private int cash;
        private System.Windows.Forms.Button btnSender, btnA, btnB, btnC, btnD;
        public List<Questions> questions;
        private QuestionService questionService;
        private int round;
        private string playerName = FormCreateGame.playerName;

        public GameController() { }

        public void UpdateGameData(object question, object money, object lRound, object lPlayer, object btnA, object btnB, object btnC, object btnD)
        {
            if (this.questions == null) GenerateQuestions();

            this.lableQuestion = (Label)question;
            this.labelMoney = (Label)money;
            this.labelRound = (Label)lRound;
            this.labelPlayer = (Label)lPlayer;
            this.btnA = (Button)btnA;
            this.btnB = (Button)btnB;
            this.btnC = (Button)btnC;
            this.btnD = (Button)btnD;

            this.labelRound.Text = (round + 1).ToString();
            this.labelPlayer.Text = this.playerName;
            this.lableQuestion.Text = this.questions[this.round].Question.ToString();

            this.btnA.Text = this.questions[this.round].Answers[0].ToString();
            this.btnB.Text = this.questions[this.round].Answers[1].ToString();
            this.btnC.Text = this.questions[this.round].Answers[2].ToString();
            this.btnD.Text = this.questions[this.round].Answers[3].ToString();

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
                MessageBox.Show("Sie haben verloren!");

                FormMenu menu = new FormMenu();
                menu.Show();
                currentForm.Hide();
            }
            else
            {
                cash += 100 * round;
            }
            this.labelMoney.Text = cash.ToString() + " MARK";
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
