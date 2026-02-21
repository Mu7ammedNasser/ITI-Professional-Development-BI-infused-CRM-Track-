using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using lab_1_EF.Models;

namespace lab_1_EF
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string? Name { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; } = null!;

        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name},Age = {Age},Salary = {Salary:C}, DepartmentID = {DepartmentID}, /// {Department} ///";
            //return $"ID = {Id}, Name = {Name}, DepartmentID = {DepartmentID}";
        }

     


    }
}
