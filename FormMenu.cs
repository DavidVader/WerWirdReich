using WerWirdReich.Models;
using WerWirdReich.Services;

namespace WerWirdReich
{
    public partial class FormMenu : Form
    {
        private FormCreateGame createGame;
        private FormOption option;

        public FormMenu()
        {
            InitializeComponent();
            setScoreBoard();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            createGame = new FormCreateGame();
            createGame.Show();
            this.Hide();
        }
        private void btnOption_Click(object sender, EventArgs e)
        {
            option = new FormOption();
            option.Show();
            this.Hide();
        }

        private void setScoreBoard()
        {
            listBoxScoreBoard.Items.Add("Anzeigetafel");
            listBoxScoreBoard.Items.Add("-----------------------------------------");

            var topPlayerList = PlayerService.GetAllPlayers().OrderByDescending(x => x.TotalMoney).ToList();

            if (topPlayerList.Count > 5)
            {
                for (int i = 0; i > 5; i++)
                {
                    listBoxScoreBoard.Items.Add((i+1) + ". " + topPlayerList[i].Name + ": " + topPlayerList[i].TotalMoney + " Mark");
                }
            }
            else
            {
                int tmpI = 0;
                for (int i = 0; i < topPlayerList.Count; i++)
                {
                    listBoxScoreBoard.Items.Add((i + 1) + ". " + topPlayerList[i].Name + ": " + topPlayerList[i].TotalMoney + " Mark");
                    tmpI = i + 1;
                }
                for (int i = tmpI; i < 5; i++)
                {
                    listBoxScoreBoard.Items.Add((i + 1) + ". SPIELER: XXX Mark");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}
