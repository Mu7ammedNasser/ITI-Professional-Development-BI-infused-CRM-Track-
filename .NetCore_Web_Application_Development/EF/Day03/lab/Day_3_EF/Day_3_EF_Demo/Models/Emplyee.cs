using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_EF_Demo.Models
{
    internal class Emplyee
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        public string Email { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public override string ToString()
        {
            return $"Emplyee Id: {Id}, Emplyee Name: {Name}, Emplyee Age: {Age}, Emplyee Salary: {Salary}, Department Id: {DepartmentId}, Email: {Email } ";
        }
    }
}
