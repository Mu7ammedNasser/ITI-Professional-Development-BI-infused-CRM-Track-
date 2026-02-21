using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        /*------------------------------------------------------------------*/
        public override string ToString()
        {
            return $"Department Id: {DeptId}, Department Name: {DeptName}";
        }
    }
}
