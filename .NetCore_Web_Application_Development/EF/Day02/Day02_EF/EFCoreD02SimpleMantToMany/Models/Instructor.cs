using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreD02SimpleMantToMany.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();



    }
}
