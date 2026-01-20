using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerWirdReich.Models
{
    public class Questions
    {
        public int Level { get; set; }
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int RightAnswer { get; set; }
    }
}
