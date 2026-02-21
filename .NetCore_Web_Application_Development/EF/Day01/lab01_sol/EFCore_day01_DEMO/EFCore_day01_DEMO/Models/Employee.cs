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
        // one to many 
        // Employee belong to one department
        // Department contains many Employees

        //FK from 1 in many 
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        // Nav Prop 
        public virtual Department Department { get; set; } = null!;
        #endregion


        public override string ToString()
        {
            return $"ID = {E_Id}, Name = {Name}, Age = {Age}, Salary = {Salary}, DepartmentID = {DepartmentID}, /// {Department} ///";
        }
    }
}
