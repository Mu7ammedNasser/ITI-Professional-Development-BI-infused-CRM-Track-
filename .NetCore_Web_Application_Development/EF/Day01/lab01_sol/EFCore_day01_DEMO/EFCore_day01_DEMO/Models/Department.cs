using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_day01_DEMO.Models
{
    public class Department
    {
        //[Key]
        public int DeptId { get; set; }
        public string? DeptName { get; set; }


        // defualt relation if i do not write the ICollection here is one to many (based on employee)
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        public override string ToString()
        {
            return $"DepartmentName = {DeptName}";
        }
    }
}
