using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WerWirdReich.Models;
using WerWirdReich.Services;

namespace WerWirdReich
{
    public partial class FormCreateGame : Form
    {
        private FormGame game;
        private FormMenu menu;
        public FormCreateGame()
        {
            InitializeComponent();
            FormClosing += CreateGame_FormClosing;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                Name = tBoxPlayer.Text,
                HighScore = 0,
                AmountOfPlaythrough = 0,
                TotalMoney = 0
            };

            PlayerService.CreatePlayer(player);
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
