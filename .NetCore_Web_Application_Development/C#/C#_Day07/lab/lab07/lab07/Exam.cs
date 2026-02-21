using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal abstract class Exam
    {
        public string? ExamType { get; set; }

        public string? ExamName { get; set; }

        public DateTime ExamDate { get; set; }

        public abstract void displayExam();
    }
}
