using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_EF_Demo.Models
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<Emplyee> Emplyees { get; set; }

        public override string ToString()
        {
            return $"Department Id: {DeptId}, Department Name: {DeptName}";
        }

    }
}
