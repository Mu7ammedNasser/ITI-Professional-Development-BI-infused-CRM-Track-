using System.Runtime.Intrinsics.X86;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            List<Employee> employees = Repository.GetAllEmployees();
            List<Department> departments = Repository.GetAllDept();


            #region 1.First 4 Employees in the List Using Method Syntax [fluent syntax].
            var q1 = employees.Take(4);
            #endregion

            #region 2.First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].
            var q2 = employees.Where(e => e.Salary > 5000).Take(3);
            #endregion

            #region 3.Last 4 Employees in the List Using Method Syntax [fluent syntax].
            var q3 = employees.TakeLast(4);
            #endregion

            #region 4.Second 2 Employees in the List Using Method Syntax [fluent syntax].
            var q4 = employees.Skip(2).Take(2);
            #endregion

            #region 5.All Employees While Name length < 5 Using Method Syntax [fluent syntax].
            var q5 = employees.Where(e => e.Name != null && e.Name.Length < 5);
            #endregion

            #region 6.Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].
            var q6 = employees.Distinct(); // will print distinct  data depends on reference not state 
            //var q6_1 = employees.DistinctBy(e =>e.Id); // will print distinct data depends on state of id column
            var q6_2 = employees.Distinct(new EmplyeeComparer());
            #endregion

            #region 7.Name and Id of All Employees Using Method Syntax [fluent syntax].
            var q7 = employees.Select(e => new { empId = e.Id, empName = e.Name });
            #endregion

            #region 8.	Name and Id of All Employees Using Query Syntax.
            var q8 = from e in employees
                     select new { empID = e.Id, empName = e.Name };
            #endregion

            #region 9.Name and DeptName of All Employees Using Query Syntax.
            var q9 = from e in employees
                     join d in departments
                     on e.DeptId equals d.DeptId
                     select new { e.Name, d.DeptName };
            #endregion

            #region 10. Name and DeptName of All Employees Using Method Syntax [fluent syntax].
            //var q10 = Enumerable.Join(
            //    employees,
            //    departments,
            //    e => e.DeptId,
            //    d=>d.DeptId ,
            //    (e,d)=> new {e.Name , d.DeptName });

            var q10 = employees.Join(
                departments,
                e => e.DeptId,
                d => d.DeptId,
                (e, d) => new { e.Name, d.DeptName });
            #endregion


            #region All Employees Group by DeptName Using Method Syntax [fluent syntax].
            var q11 = employees.Join(
                departments,
                e => e.DeptId,
                d => d.DeptId,
                (e, d) => new { Emplyoee = e, departmentName = d.DeptName })
                .GroupBy(h => h.departmentName);
            #endregion

            #region 12.All Employees Group by DeptName Using Query Syntax.
            var q12 = from e in employees
                      join d in departments
                      on e.DeptId equals d.DeptId
                      group e by d.DeptName; // e here what i will put into the group and now q12 have ienumrable of i grouping 
            #endregion

            #region 13.Min Salary, Max Salary, Avg Salary.
            var q13_1 = employees.Min(e => e.Salary);
            var q13_2 = employees.Max(e => e.Salary);
            var q13_3 = employees.Average(e => e.Salary);
            #endregion

            #region 14.Employee Where Salary < Avg Salary
            var q14 = employees.Where(e => e.Salary < employees.Average(e => e.Salary));
            #endregion

            #region 15.Create two lists of int and try Expect, Concat, Union, Intersect.
            List<int> ints = new List<int> { 0, 1, 1, 2, 3, 4, 4 };
            List<int> ints2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            var q15_1 = ints.Except(ints2);
            var q15_2 = ints.Concat(ints2);
            var q15_3 = ints.Union(ints2);
            var q15_4 = ints.Intersect(ints2);
            #endregion


            #region 16.Create list of Phone Number and Names and try Zip Operator.
            var names = new List<string> { "Nasser", "Ahmed", "Mona" };
            var phones = new List<string> { "0101111", "0102222", "0103333", "0104444" };

            var q16 = names.Zip(phones, (name, phone) => new { userName = name, userPhone = phone });

            #endregion







            //foreach (var item in q16)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in q12)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var e in item)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            #endregion

            #region part02


            #region 1- Declare a List of numbers as shown
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            #region Query1: Display numbers without any repeated Data and sorted 
            var q17 = numbers.Distinct()
                .OrderBy(n => n); // froe each elemet in distinct numbers use the value itself for sorting 
            #endregion
            #region Query2: using Query1  result and show each number and it’s multiplication  

            // select used to project each element of q18 into anoother object 
            // n=> new : this will map each element to new object or i can say for each element in q17 return something 
            var q18 = q17.Select(n => new { Number = n, Multiplay = n * n }); // so now q18 is IEnumrable<`a> 

            #endregion

            #endregion

            #region 2- declare an array of names as shown

            string[] _names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            #region Query1: Select names with length equal 3.  
            var q19_1 = _names.Where(n => n.Length == 3);

            var q19_2 = from n in _names
                        where n.Length == 3
                        select n;

            #endregion

            #region Query2: Select names that contains “a” letter (Capital or Small )then sort them by length
            var q20_1 = _names.Where(n => n.Contains('a') || n.Contains('A'));

            var q20_2 = from n in _names
                        where n.Contains('a') || n.Contains('A')
                        select n;
            #endregion

            #region Query3: Display the first 2 names  
            var q21_1 = _names.Take(3);
            var q21_2 = (from n in _names
                         select n).
                        Take(2);

            #endregion



            #endregion

            #region 3- Declare a class Subject that contains the following properties
            List<Student> students = new List<Student>
            {
                new Student()
                {
                    Id = 1,
                    FName = "Ali",
                    LName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 33, Name = "UML" }
                    }
                },
                new Student()
                {
                    Id = 2,
                    FName = "Mona",
                    LName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    Id = 3,
                    FName = "Yara",
                    LName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    Id= 4,
                    FName = "Ali",
                    LName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 33, Name = "UML" }
                    }
                }
            };

            #region Query1: Display Full name and number of subjects for each student as follow 
            var q22 = students.Select(s => new { FullName = s.FName + ' ' + s.LName, NoOfSubjects = s.Subjects.Length });

            #endregion

            #region Query2: Write a query which orders the elements in the list...
            var q23 = students.OrderByDescending(s => s.FName)
                              .ThenBy(s => s.LName)
                              .Select(s => new { s.FName, s.LName });
            #endregion

            #region Query2: Display each student and student’s subject as follow (use selectMany) 
            // in this case it;s better to back to user an flatten object 
            var q24 = students.SelectMany(
                s => s.Subjects,
                (student, subject) => new
                {
                    StudentName = student.FName + " " + student.LName,
                    SubjectName = subject.Name,
                }
            );
            #endregion

            #region Query3:Display each student and student’s subject as follow (use selectMany)  
                var q25 = students.SelectMany(
                    s => s.Subjects,
                    (student, subject) => new
                    {
                        StudentName = student.FName + " " + student.LName,
                        SubjectName = subject.Name,
                    }
                ).GroupBy(s => s.StudentName);

            #endregion

            #region Query4: Then as follow (use GroupBy)  
            foreach (var group in q25)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var st in group)
                {
                    Console.WriteLine(st.SubjectName);
                }
            }

            #endregion

            #endregion




            #endregion

        }
    }
}
