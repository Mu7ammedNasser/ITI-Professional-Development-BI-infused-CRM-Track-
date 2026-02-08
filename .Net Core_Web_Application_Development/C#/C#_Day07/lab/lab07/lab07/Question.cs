using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{   
    internal abstract class Question
    {
        public int Id { get; set; }
        public string? QBody { get; set; }
        public QuestType QuestType { get; set; }
        public List<Choice>? Choices { get; set; }

        public int Mark { get; set; }

        public string? CorrectAnswer {get; set;} // for TF

        public abstract void DisplayQues();

    }
}
