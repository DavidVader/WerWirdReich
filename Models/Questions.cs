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
