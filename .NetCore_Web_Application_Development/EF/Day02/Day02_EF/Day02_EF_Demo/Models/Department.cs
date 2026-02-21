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
        public int DeptId { get; set; }

        [MaxLength(30)]
        public string DeptName { get; set; }

        [MaxLength(30)]
        public string? DeptDesc { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        public override string ToString()
        {
            return $"DepartmentName = {DeptName}";
        }
    }
}
