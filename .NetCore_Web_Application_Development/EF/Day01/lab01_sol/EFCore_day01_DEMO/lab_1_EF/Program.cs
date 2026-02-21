using System.Collections.Generic;
using lab_1_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_1_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part_1
            MyContext db = new MyContext();
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
            #region 1.	Insert 5 Departments.

            //var d1 = new Department { DeptName = "SD" };
            //var d2 = new Department { DeptName = "UI" };
            //var d3 = new Department { DeptName = "CS" };
            //var d4 = new Department { DeptName = "IS" };
            //var d5 = new Department { DeptName = "AI" };

            //db.AddRange(d1, d2, d3, d4, d5);



            #endregion

            #region 2.	Insert 10 Students
            var s1 = new Student { Name = "Ahmed", Age = 22, Salary = 3000, DepartmentID = 1 };
            var s2 = new Student { Name = "Mohamed", Age = 35, Salary = 6000, DepartmentID = 2 };
            var s3 = new Student { Name = "Mona", Age = 28, Salary = 4500, DepartmentID = 1 };
            var s4 = new Student { Name = "Sara", Age = 40, Salary = 7000, DepartmentID = 3 };
            var s5 = new Student { Name = "Mahmoud", Age = 25, Salary = 5200, DepartmentID = 4 };
            var s6 = new Student { Name = "Yasmine", Age = 32, Salary = 4800, DepartmentID = 1 };
            var s7 = new Student { Name = "Mostafa", Age = 29, Salary = 3900, DepartmentID = 5 };
            var s8 = new Student { Name = "Hany", Age = 45, Salary = 8000, DepartmentID = 2 };
            var s9 = new Student { Name = "Mariam", Age = 25, Salary = 4100, DepartmentID = 5 };
            var s10 = new Student { Name = "Karim", Age = 31, Salary = 2000, DepartmentID = 2 };

            db.Students.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);


            #endregion

            #region 3.	Display all Students.
            //var allstudents = db.Students;

            //foreach (var student in allstudents)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region 4.	Display all Departments.
            //var allDept = db.Departments;
            //foreach (var dept in allDept)
            //{
            //    Console.WriteLine(dept);
            //}
            #endregion

            #region 5.	Display Students With Department Name. [Using Include]
            //var allstud = db.Students.Include(e => e.Department);
            //foreach (var student in allstud)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region 6.	Display Students With Department Name in Department Id = 1. [Using Include]
            //var student = db.Students.Include(s => s.Department)
            //                           .FirstOrDefault(s => s.DepartmentID == 1);
            //Console.WriteLine(student);
            #endregion

            #region 7.	Display all Students with DeptId =1 OrderBy Name descending.
            //var allStudent = db.Students.Where(s => s.DepartmentID == 1).Include(s=>s.Department).OrderByDescending(s=>s.Name);
            //foreach (var stud in allStudent)
            //{
            //    Console.WriteLine(stud);
            //}
            #endregion

            //db.SaveChanges();
            #endregion

            #region Part_2
            #region 1.Display all Student using LINQ Query Expression.
            //var allstudent = from s in db.Students
            //                 select s;

            //foreach (var student in allstudent)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region 2.	Display all Student using LINQ Method Syntax [fluent syntax].
            //var allstudent = db.Students.Include(s => s.Department);
            //foreach (var student in allstudent)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region 3.	Display all Students with Age > 30 using LINQ Query Expression.
            //var allStudent = from s in db.Students
            //                 where s.Age > 30
            //                 select s;
            //foreach (var item in allStudent)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.	Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
            //var allStud = db.Students.Where(s => s.Salary < 5000);
            //foreach (var item in allStud)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5.	Display all Students with DepartmentId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            //var students = from s in db.Students
            //               where s.DepartmentID == 1 && s.Salary>4000
            //               orderby s.Name descending
            //               select s;
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6.	Display all Students with DepartmentId = 1 and Name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
            //var students = db.Students.Where(s => s.Id == 1 && s.Name != null && s.Name.ToLower().Contains("m")).OrderBy(s=>s.Salary);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7.	Find First Student with Salary more than 5000.Hint: (using First and FirstOrDefault)
            //var student = db.Students.First(s=>s.Salary > 5000);
            //var student = db.Students.FirstOrDefault(s=>s.Salary > 5000);
            //Console.WriteLine(student);

            #endregion

            #region 8.	Find Last Student in Department number 10.Hint: (using Last and LastOrDefault)
            //var lastStudent = db.Students
            //    .OrderBy(s => s.Id)
            //    .Last(s => s.DepartmentID == 10);
            //    //.LastOrDefault(s => s.DepartmentID == 10);
            //Console.WriteLine(lastStudent);

            #endregion

            #region 9.	Find Student with Age equal 25.Hint: (using Single and SingleOrDefault)
            //var singleStudent = db.Students.SingleOrDefault(s=>s.Age == 25);
            //var singleStudent = db.Students.Single(s=>s.Age == 25);
            //Console.WriteLine(singleStudent);

            #endregion

            #region 10.	Find Student with DepartmentId equal 8.Hint: (using Single and SingleOrDefault)
            //var student = db.Students
            //    //.SingleOrDefault(s => s.DepartmentID == 8);
            //    .Single(s => s.DepartmentID == 8);
            //Console.WriteLine(student);
            #endregion
            #endregion
        }
    }
}
