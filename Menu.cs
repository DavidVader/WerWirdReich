namespace WerWirdReich
{
    public partial class Menu : Form
    {
        private Game gameForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            gameForm = new Game();
            gameForm.Show();
            this.Hide();
        }
    }
}
