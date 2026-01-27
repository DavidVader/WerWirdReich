using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WerWirdReich.Models;

namespace WerWirdReich.Services
{
    internal class QuestionService
    {
        public List<Questions> GetQuestions()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "Fragen.json");
            string jsonString = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Questions> allQuestions = JsonSerializer.Deserialize<List<Questions>>(jsonString, options);

            Random rnd = new Random();
            List<Questions> result = new List<Questions>();

            var grouped = allQuestions.GroupBy(q => q.Level);

            foreach (var group in grouped)
            {
                var list = group.ToList();
                result.Add(list[rnd.Next(list.Count)]);
            }

            return result;
        }

    }
}
