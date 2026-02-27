using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using WMPLib;

namespace WerWirdReich
{
    public partial class FormOption : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer;

        public FormOption()
        {
            InitializeComponent();
        }

        private void music_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Assets\WwMTheme.wav");
            player.Play();
            new SoundPlayer(@"C:\Users\Startklar\source\repos\Test Soundfgwfg\Resources\WwMTheme.wav").PlayLooping();
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Hide();
    }
}
