using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    struct Employee
    {
        #region data
        int id;
        string name;
        int age;
        double salary;
        HiringDate h1;
        Gender g1;
        SecurityLevel s1;
        #endregion

        #region ctor
        public Employee(int _id, string _name, int _age, double _salary, HiringDate _h1, Gender _g1, SecurityLevel _s1)
        {
            id = _id;
            name = _name;
            age = _age;
            salary = _salary;
            h1 = _h1;
            g1 = _g1;
            s1 = _s1;

        }
        #endregion

        #region setter & getter
        public void SetId(int _id) { id = _id; }
        public void SetName(string _name) { name = _name; }
        public void SetAge(int _age) { age = _age; }
        public void SetSalary(double _salary) { salary = _salary; }
        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetAge() { return age; }
        public double GetSalary() { return salary; }
        public void SetHiringDate(HiringDate _h1) { h1 = _h1; }
        public HiringDate GetHiringDate() { return h1; }
        public void SetGender(Gender _g1) { g1 = _g1; }
        public Gender GetGender() { return g1; }
        public void SetSecurityLevel(SecurityLevel _s1) { s1 = _s1; }
        public SecurityLevel GetSecurityLevel() { return s1; }

        #endregion


        #region print method
        public string Print()
        {
            return $"id: {id}, name: {name}, age: {age}, salary: {salary},hiringdate: {h1.Print()}, gender: {g1},securitylevel: {s1}";

        }
        #endregion


    }
}
}
