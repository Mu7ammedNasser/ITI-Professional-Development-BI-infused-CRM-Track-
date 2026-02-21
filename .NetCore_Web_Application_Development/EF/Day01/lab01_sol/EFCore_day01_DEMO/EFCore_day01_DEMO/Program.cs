using EFCore_day01_DEMO.Context;
using EFCore_day01_DEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_day01_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyContext db = new MyContext();

            #region DB Creation Strategy
            //applay all Configration 
            // create db if no one created 
            // Dev only 
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
            #endregion

            #region Employee and dept without relation

            //Employee e1 = new Employee() { Name = "Nasser", Age = 22, Salary = 3000 };
            //Employee e2 = new Employee() { Name = "Ahmed", Age = 33, Salary = 30_000 };
            //var d1 = new Department { DeptName = "SD" }; 

            ////add e1 into local container
            //db.Add(e1);
            //db.Add(e2);
            //db.Add(d1);
            #endregion

            #region Employee and Department with relation 
            //var d1 = new Department { DeptName = "UI" };
            //db.Add(d1);

            // one trip to db better performance
            //var e1 = new Employee { Age = 22, Name = "Nasser", Salary = 30_000 , DepartmentID = 1 };
            //db.Add(e1);

            // two trips to db
            //var dept = db.Departments.Skip(1).Take(1).FirstOrDefault();
            //if (dept is not null)
            //{
            //    var e1 = new Employee
            //    {
            //        Name = "doaa",
            //        Salary = 45_000,
            //        Age = 30,
            //        Department = dept
            //    };
            //    db.Add(e1);
            //}
            #endregion

            #region Employee and Department with relation and shadow foriegn key 

            #endregion

            #region CRUD
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            #region Add Department
            //var d1 = new Department { DeptName = "SD" };
            //var d2 = new Department { DeptName = "UI" };
            //var d3 = new Department { DeptName = "MOB" };
            //var d4 = new Department { DeptName = "WC" };
            //db.Departments.Add(d1);
            //db.Add(d2);
            //db.AddRange([3,4]);
            //db.AddRange(d3,d4);
            #endregion

            #region Add Employee
            //var e1 = new Employee { Name = "Nasser", Salary = 35_000, Age = 22, DepartmentID = 1 };
            //var e2 = new Employee { Name = "Ahmed", Salary = 38_000, Age = 22, DepartmentID = 2 };
            //var e4 = new Employee { Name = "Mostafa", Salary = 30_000, Age = 22, DepartmentID = 3 };
            //var e3 = new Employee { Name = "Doaa", Salary = 39_000, Age = 22, DepartmentID = 4 };

            //db.AddRange(e1, e2, e3, e4);
            #endregion

            #region Get All Employees
            #region default no join happens as u see in the equivalent query
            //SELECT [e].[E_Id], [e].[Age], [e].[DepartmentID], [e].[Name], [e].[Salary]
            //FROM[employees] AS[e]
            //var allEmps = db.employees;
            //foreach (var emp in allEmps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Eager Loading
            //equivalent query
            /// SELECT [e].[E_Id], [e].[Age], [e].[DepartmentID], [e].[Name], [e].[Salary], [d].[DeptId], [d].[DeptName]
            /// FROM [employees] AS [e]
            /// INNER JOIN [Departments] AS [d] ON [e].[DepartmentID] = [d].[DeptId]

            //var allEmps = db.employees.Include(e => e.Department);
            //foreach (var emp in allEmps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Lazy Loading 
            //var emp = db.employees.FirstOrDefault();
            //Console.WriteLine(emp);
            //N + 1 problem
            //var allEmp = db.employees.ToList();
            //foreach (var emp in allEmp)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
            #endregion

            #region Delete 
            //1 - catch to delete
            //var empToDel = db.employees.FirstOrDefault(e => e.E_Id == 4);
            //if (empToDel is not null)
            //{
            //    db.Remove(empToDel);
            //}
            #endregion

            #region Update
            //V01
            // 1- catch to update 
            //var empToUpdate = db.employees.FirstOrDefault(e => e.E_Id == 3);

            //if (empToUpdate is not null)
            //{
            //    empToUpdate.Name = "nasser updated";
            //}

            //V02


            #endregion

            #endregion


            //Affect to dataBase
            db.SaveChanges();

        }
    }
}
