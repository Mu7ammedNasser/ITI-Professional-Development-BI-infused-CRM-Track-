using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal static class Repository
    {
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee(){ Id = 1, Name = "Nasser",   Age = 22, Salary = 30_000, DeptId = 1 },
                new Employee(){ Id = 2, Name = "Ahmed",    Age = 28, Salary = 45_000, DeptId = 2 },
                new Employee(){ Id = 3, Name = "Mona",     Age = 26, Salary = 38_000, DeptId = 1 },
                new Employee(){ Id = 4, Name = "Omar",     Age = 35, Salary = 60_000, DeptId = 3 },
                new Employee(){ Id = 5, Name = "Sara",     Age = 30, Salary = 50_000, DeptId = 2 },
                new Employee(){ Id = 6, Name = "Hassan",   Age = 24, Salary = 32_000, DeptId = 1 },
                new Employee(){ Id = 6, Name = "Hassan",   Age = 24, Salary = 32_000, DeptId = 1 },
                new Employee(){ Id = 6, Name = "Hassan",   Age = 24, Salary = 32_000, DeptId = 1 },
                new Employee(){ Id = 7, Name = "Yara",     Age = 29, Salary = 47_000, DeptId = 3 },
                new Employee(){ Id = 7, Name = "Yara",     Age = 29, Salary = 47_000, DeptId = 3 },
                new Employee(){ Id = 8, Name = "Khaled",   Age = 40, Salary = 70_000, DeptId = 2 }
            };

        }

        public static List<Department> GetAllDept()
        {
            return new List<Department>
            {
                new Department(){ DeptId = 1, DeptName = "HR" },
                new Department(){DeptId = 2, DeptName = "IT"},
                new Department(){DeptId = 3, DeptName = "Finance"}
            };
        }
    }
}
