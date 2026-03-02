using NAudio.Wave;

namespace WerWirdReich.Services
{
    public static class MusicService
    {
        private static AudioFileReader audioFile;
        private static WaveOutEvent outputDevice;
        private static readonly string musicFilePath;
        private static bool isPlaying = false;
        private static float currentVolume = 0.5f;

        static MusicService()
        {
            musicFilePath = Path.Combine(AppContext.BaseDirectory, "Assets", "WwMTheme.wav");
        }

        public static void StartMusic()
        {
            if (isPlaying) return;

            try
            {
                audioFile = new AudioFileReader(musicFilePath);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);

                // Lautstärke setzen
                audioFile.Volume = currentVolume;

                outputDevice.Play();
                isPlaying = true;

                // Für Endlosschleife
                outputDevice.PlaybackStopped += (s, e) =>
                {
                    if (isPlaying) // Nur wiederholen wenn wir noch spielen wollen
                    {
                        audioFile.Position = 0;
                        outputDevice.Play();
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Musik konnte nicht geladen werden: {ex.Message}", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void StopMusic()
        {
            if (!isPlaying) return;

            try
            {
                outputDevice?.Stop();
                isPlaying = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Stoppen: {ex.Message}");
            }
        }

        public static void PauseMusic()
        {
            if (isPlaying && outputDevice != null)
            {
                outputDevice.Pause();
                isPlaying = false;
            }
        }

        public static void ResumeMusic()
        {
            if (!isPlaying && outputDevice != null)
            {
                outputDevice.Play();
                isPlaying = true;
            }
        }

        public static void SetVolume(int volumePercent)
        {
            // Volume von 0-100 auf 0.0-1.0 umrechnen
            currentVolume = Math.Clamp(volumePercent / 100f, 0f, 1f);

            if (audioFile != null)
            {
                audioFile.Volume = currentVolume;
            }
        }

        public static int GetVolumePercent()
        {
            return (int)(currentVolume * 100);
        }

        public static bool IsPlaying
        {
            get { return isPlaying; }
        }

        public static void Cleanup()
        {
            StopMusic();

            outputDevice?.Dispose();
            audioFile?.Dispose();

            outputDevice = null;
            audioFile = null;
        }
    }
}