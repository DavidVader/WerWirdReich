using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerWirdReich
{
    public partial class FormCreateGame : Form
    {
        private FormGame game;
        public FormCreateGame()
        {
            InitializeComponent();
            FormClosing += CreateGame_FormClosing;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new FormGame();
            game.Show();
            this.Hide();
        }

        private void CreateGame_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
