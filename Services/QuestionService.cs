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
        public List<Questions> getQuestions()
        {
            List<Questions> tempListeJS = new List<Questions>();
            List<Questions> returnListeJS = new List<Questions>();
            Random rnd = new Random();

            int zahl;
            int zahlOffset = 0;

            string jsonString = File.ReadAllText("Data/Fragen.json");

            List<Questions> allQuestions = JsonSerializer.Deserialize<List<Questions>>(jsonString);

            for (int i = 0; i <= 3; i++)
            {
                tempListeJS.Clear();

                for (int z = 0; z <= 2; z++)
                {
                    Questions frage = allQuestions[zahlOffset + z];
                    tempListeJS.Add(frage);
                }

                zahlOffset += 3;

                zahl = rnd.Next(3);
                returnListeJS.Add(tempListeJS[zahl]);
            }

            return returnListeJS;
        }

    }
}
