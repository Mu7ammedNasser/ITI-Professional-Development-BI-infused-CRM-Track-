using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public double Salary { get; set; }

        public HiringDate? hireDate { get; set; }

        public Gender gender { get; set; }

        public SecurityLevel securityLevel { get; set; }

        public Employee()
        {
            Id = 0;
            Name = null;
            Age = 0;
            Salary = 0;
            hireDate = null;
            gender = Gender.M;
            securityLevel = SecurityLevel.guest;

        }

        public Employee(int _id, string _name, int _age, double _salary, HiringDate _hireDate, Gender gender, SecurityLevel _securityLevel)
        {
            this.Id = _id;
            this.Name = _name; 
            this.Age = _age;
            this.Salary = _salary;
            this.hireDate = _hireDate;
            this.gender = gender;
            this.securityLevel = _securityLevel;
        }

        public override string ToString()
        {
            return $"ID = {this.Id} , $Role{this.securityLevel}";
        }
    }
}
