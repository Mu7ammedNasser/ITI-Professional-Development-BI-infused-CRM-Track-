using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_day01_DEMO.Models
{
    public class Employee
    {
        public int E_Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        #region Relation

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; } = null!;
        #endregion


        public override string ToString()
        {
            return $"ID = {E_Id}, Name = {Name}, Age = {Age}, Salary = {Salary}, DepartmentID = {DepartmentID}, /// {Department} ///";
        }
    }
}


// Before C#8
// Reference types (classes) are nullable by default, and value types (structs) are non-nullable by default.
// After C#8
// non-nullable reference types 
// Fire warning 