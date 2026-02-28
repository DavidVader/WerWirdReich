using System.Text.Json;
using WerWirdReich.Models;

namespace WerWirdReich.Services
{
    class PlayerService
    {
        private static readonly string SaveFilePath = Path.Combine(AppContext.BaseDirectory, "Data", "player.json");

        public static List<Player> GetAllPlayers()
        {
            if (!File.Exists(SaveFilePath))
            {
                return new List<Player>();
            }
            try
            {
                string json = File.ReadAllText(SaveFilePath);
                return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
            }
            catch
            {
                return new List<Player>();
            }
        }
        public static Player GetPlayer(string playerName)
        {
            var players = GetAllPlayers();
            return players.FirstOrDefault(p => p.Name == playerName);
        }
        public static bool CreatePlayer(Player newPlayer)
        {
            try
            {
                var players = GetAllPlayers();
                if (players.Any(p => p.Name == newPlayer.Name))
                {
                    return false;
                }
                players.Add(newPlayer);
                SaveAllPlayers(players);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool EditPlayer(string playerName, Player updatedPlayer)
        {
            try
            {
                var players = GetAllPlayers();
                var playerIndex = players.FindIndex(p => p.Name == playerName);
                if (playerIndex >= 0)
                {
                    players[playerIndex] = updatedPlayer;
                    SaveAllPlayers(players);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private static void SaveAllPlayers(List<Player> players)
        {
            try
            {
                string directory = Path.GetDirectoryName(SaveFilePath);
                if (!Directory.Exists(directory) && !string.IsNullOrEmpty(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(players, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(SaveFilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving players: {ex.Message}");
            }
        }
    }
}
