using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        public int DeptId { get; set; }
        // Navigation property to Department
        // References the Department object associated with this employee
        // Assosiation
        public Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DeptId}";
        }
    }
}
