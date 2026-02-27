using WerWirdReich.Models;
using WerWirdReich.Services;

namespace WerWirdReich
{
    public partial class FormCreateGame : Form
    {
        private FormGame game;
        private FormMenu menu;
        private List<Player> playerList = PlayerService.GetAllPlayers();

        public static string playerName = "";
        public FormCreateGame()
        {
            InitializeComponent();
            FormClosing += CreateGame_FormClosing;

            foreach (Player player in this.playerList)
            {
                cBoxPlayers.Items.Add(player.Name);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tBoxPlayer.Text))
            {
                var player = new Player
                {
                    Name = tBoxPlayer.Text,
                    HighScore = 0,
                    AmountOfPlaythrough = 0,
                    TotalMoney = 0
                };
                playerName = tBoxPlayer.Text;
                PlayerService.CreatePlayer(player);
            }
            else if (cBoxPlayers.SelectedItem != null)
            {
                playerName = cBoxPlayers.SelectedItem.ToString();
            }
            else if (this.playerList[0] == null)
            {
                playerName = "Spieler1";
                var player = new Player
                {
                    Name = playerName,
                    HighScore = 0,
                    AmountOfPlaythrough = 0,
                    TotalMoney = 0
                };
                PlayerService.CreatePlayer(player);
            }
            else
            {
                playerName = this.playerList[0].Name;
            }
            game = new FormGame();
            game.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void CreateGame_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
