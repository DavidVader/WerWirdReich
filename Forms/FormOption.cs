using NAudio.Wave;
using WerWirdReich.Services;

namespace WerWirdReich
{
    public partial class FormOption : Form
    {
        //private readonly string musicFilePath = Path.Combine(AppContext.BaseDirectory, "Assets", "WwMTheme.wav");
        //private AudioFileReader audioFile;
        //private WaveOutEvent outputDevice;
        //private bool isPlaying = false;

        public FormOption()
        {
            InitializeComponent();

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = MusicService.GetVolumePercent();
            trackBar1.Scroll += TrackBar1_Scroll;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            MusicService.SetVolume(trackBar1.Value);
            labelVolume.Text = trackBar1.Value.ToString();
        }

        private void btnMusicOn_Click(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Click();

            if (!MusicService.IsPlaying)
            {
                MusicService.StartMusic();
            }
            else
            {
                MusicService.ResumeMusic();
            }
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            SoundService.ButtonSounds.Click();

            MusicService.PauseMusic(); // oder StopMusic()
        }
        private void btnBack_Click(object sender, EventArgs e) => this.Hide();
    }
}