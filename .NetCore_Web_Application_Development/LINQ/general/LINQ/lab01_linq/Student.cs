using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_linq
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int TrackId { get; set; }

        public Track? Track { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {FName} {LName}, Age: {Age}, Salary: {Salary:C}, TrackId: {TrackId}";
        }

    }
}
