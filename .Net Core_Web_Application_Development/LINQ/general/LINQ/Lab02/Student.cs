using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab02
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public Subject[] Subjects { get; set; }

    }
}
