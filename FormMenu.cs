namespace WerWirdReich
{
    public partial class FormMenu : Form
    {
        private FormCreateGame createGame;
        private FormOption option;

        public FormMenu()
        {
            InitializeComponent();
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

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}
