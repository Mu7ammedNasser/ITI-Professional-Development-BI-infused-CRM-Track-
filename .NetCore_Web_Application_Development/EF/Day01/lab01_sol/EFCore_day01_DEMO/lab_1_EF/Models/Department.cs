using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_EF.Models
{
    internal class Department
    {
        [Key]
        public int DeptID { get; set; }

        [MinLength(2)]
        [MaxLength(25)]
        public string? DeptName { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public override string ToString()
        {
            return $"DeptId = {DeptID}, DeptName = {DeptName}";
        }
    }
}
