using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerWirdReich.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int HighScore { get; set; }
        public int AmountOfPlaythrough { get; set; }
        public int TotalMoney { get; set; }
    }
}
