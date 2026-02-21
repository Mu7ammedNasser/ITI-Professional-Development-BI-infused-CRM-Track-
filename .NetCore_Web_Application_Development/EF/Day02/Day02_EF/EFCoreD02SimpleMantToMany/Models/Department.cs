using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreD02SimpleMantToMany.Models
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; } = string.Empty;
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
