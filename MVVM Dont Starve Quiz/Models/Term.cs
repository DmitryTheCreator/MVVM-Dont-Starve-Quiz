using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
        //private string _picture;
        //public string Picture { get => _picture; set => _picture = "{ StaticResourse " + value + "}"; }
        public string Picture { get; set; }
    }
    public class Answer
    {
        public string Text { get; set; }
        public uint Id { get; set; }
    }
}
