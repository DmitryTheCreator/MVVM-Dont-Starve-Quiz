using System.Collections.ObjectModel;

namespace MVVM_Dont_Starve_Quiz.Models
{
    public abstract class Term
    {
        public string Question { get; set; }
        public uint Id { get; set; }
    }

    public class Factor : Term
    {
        public ObservableCollection<Answer> Answers { get; set; }
    }

    public class Goal : Term
    {
        public string Description { get; set; }
        public string Picture { get; set; }
    }
    public class Answer
    {
        public string Text { get; set; }
        public uint Id { get; set; }
    }
}
