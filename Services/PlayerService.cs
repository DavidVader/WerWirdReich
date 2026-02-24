using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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

                // Check if player already exists
                if (players.Any(p => p.Name == newPlayer.Name))
                {
                    return false; // Player already exists
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
        //public static bool CreatePlayer(string name, int highScore = 0, int playthrough = 0, int money = 0)
        //{
        //    var player = new Player
        //    {
        //        Name = name,
        //        HighScore = highScore,
        //        AmountOfPlaythrough = playthrough,
        //        TotalMoney = money
        //    };

        //    return CreatePlayer(player);
        //}
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

                return false; // Player not found
            }
            catch
            {
                return false;
            }
        }
        public static bool EditPlayerProperty(string playerName, Action<Player> updateAction)
        {
            try
            {
                var players = GetAllPlayers();
                var player = players.FirstOrDefault(p => p.Name == playerName);

                if (player != null)
                {
                    updateAction(player);
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
        public static bool DeletePlayer(string playerName)
        {
            try
            {
                var players = GetAllPlayers();
                var playerToRemove = players.FirstOrDefault(p => p.Name == playerName);

                if (playerToRemove != null)
                {
                    players.Remove(playerToRemove);
                    SaveAllPlayers(players);
                    return true;
                }

                return false; // Player not found
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
                // Create directory if it doesn't exist
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
