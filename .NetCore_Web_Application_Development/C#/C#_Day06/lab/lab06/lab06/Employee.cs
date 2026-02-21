using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal struct Employee : IComparable
    {
        #region data

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public SecurityLevel securityLevel { get; set; }
        public Gender gender { get; set; }
        public HiringDate hiringDate{ get; set; }
    
        #endregion

        #region ctor
        public Employee(int _id, string _name, int _age, double _salary, HiringDate _h1, Gender _g1, SecurityLevel _s1)
        {
            Id = _id;
            Name = _name;
            Age = _age;
            Salary = _salary;
            hiringDate = _h1;
            gender = _g1;
            securityLevel = _s1;
        }


        #endregion
        public override string ToString()
        {
            return $"id: {Id}, name: {Name}, age: {Age}, salary: {Salary},hiringdate: {hiringDate}, gender: {gender},securitylevel: {securityLevel}";
        }

        public int CompareTo(object? obj)
        {
            var empohiringDate = (Employee)obj!;
            return this.hiringDate.CompareTo(empohiringDate.hiringDate);
        }
    }
}
