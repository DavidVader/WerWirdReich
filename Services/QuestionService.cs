using System.Text.Json;
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

            var easy = allQuestions.Where(q => q.Level == 1).ToList();
            var normal = allQuestions.Where(q => q.Level == 2).ToList();
            var hard = allQuestions.Where(q => q.Level == 3).ToList();

            AddRandom(result, easy, 2, rnd);
            AddRandom(result, normal, 3, rnd);
            AddRandom(result, hard, 5, rnd);

            return result;
        }

        private void AddRandom(List<Questions> target, List<Questions> source, int count, Random rnd)
        {
            for (int i = 0; i < count && source.Count > 0; i++)
            {
                int index = rnd.Next(source.Count);
                target.Add(source[index]);
                source.RemoveAt(index);
            }
        }
    }
}
