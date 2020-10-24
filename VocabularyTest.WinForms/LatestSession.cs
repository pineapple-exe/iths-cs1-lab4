
namespace VocabularyTest.WinForms
{
    public class LatestSession
    {
        public string Name { get; set; }
        public int PracticedWords { get; set; }
        public int Score { get; set; }

        public LatestSession(string name)
        {
            Name = name;
        }
    }
}
