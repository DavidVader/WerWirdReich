using NAudio.Wave;
using System.Collections.Concurrent;

namespace WerWirdReich.Services
{
    public static class SoundService
    {
        private static readonly string basePath = Path.Combine(AppContext.BaseDirectory, "Assets", "Sounds");

        // Für gleichzeitiges Abspielen mehrerer Sounds
        //private static ConcurrentDictionary<string, WaveOutEvent> activeSounds = new();

        static SoundService()
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }

        /// <summary>
        /// Spielt einen WAV oder MP3 Sound ab
        /// </summary>
        public static void PlaySound(string soundFileName, float volume = 1.0f)
        {
            try
            {
                string fullPath = Path.Combine(basePath, soundFileName);

                if (!File.Exists(fullPath))
                {
                    // Versuche mit verschiedenen Erweiterungen
                    if (File.Exists(Path.Combine(basePath, soundFileName + ".wav")))
                        fullPath = Path.Combine(basePath, soundFileName + ".wav");
                    else if (File.Exists(Path.Combine(basePath, soundFileName + ".mp3")))
                        fullPath = Path.Combine(basePath, soundFileName + ".mp3");
                    else
                        return;
                }

                // Neuen Thread für Sound starten (damit UI nicht blockiert)
                Task.Run(() =>
                {
                    try
                    {
                        if (fullPath.EndsWith(".wav"))
                        {
                            PlayWavFile(fullPath, volume);
                        }
                        else if (fullPath.EndsWith(".mp3"))
                        {
                            PlayMp3File(fullPath, volume);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Sound: {ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }

        private static void PlayWavFile(string path, float volume)
        {
            using (var audioFile = new AudioFileReader(path))
            using (var outputDevice = new WaveOutEvent())
            {
                audioFile.Volume = volume;
                outputDevice.Init(audioFile);
                outputDevice.Play();

                // Warten bis der Sound fertig ist
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }

        private static void PlayMp3File(string path, float volume)
        {
            using (var audioFile = new AudioFileReader(path))
            using (var outputDevice = new WaveOutEvent())
            {
                audioFile.Volume = volume;
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }

        /// <summary>
        /// Spielt Sound und wartet bis er fertig ist
        /// </summary>
        public static void PlaySoundSync(string soundFileName, float volume = 1.0f)
        {
            // Synchrone Version - blockiert bis Sound fertig
            var task = Task.Run(() => PlaySound(soundFileName, volume));
            task.Wait();
        }

        /// <summary>
        /// Vordefinierte Button-Sounds
        /// </summary>
        public static class ButtonSounds
        {
            public static void Click() => PlaySound("button", 1.0f);
            public static void Success() => PlaySound("success", 1.0f);
            public static void Joker() => PlaySound("joker", 0.6f);
            public static void Money() => PlaySound("money", 0.6f);
            public static void Wrong() => PlaySound("wrong-answer", 0.8f);
        }
    }
}