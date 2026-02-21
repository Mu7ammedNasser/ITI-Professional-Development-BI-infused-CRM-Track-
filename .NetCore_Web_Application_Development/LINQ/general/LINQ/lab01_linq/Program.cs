namespace lab01_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_ = Repository.GetAllStudents();
            //_ = Repository.GetAllTracks();

            var students = Repository.GetAllStudents();
            var tracks = Repository.GetAllTracks();
            #region 1.Display all Student using LINQ Query Expression.
            //var q = from student in students
            //         select student;

            #endregion

            #region 2.Display all Student using LINQ Method Syntax [fluent syntax].
            //var q = students.Select(s => s);

            #endregion

            #region 3.Display all Students with Age > 30 using LINQ Query Expression
            //var q = from student in students
            //        where student.Age > 30
            //        select student;

            #endregion

            #region 4.Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
            //var q = students.Where(s => s.Salary > 5000);
            #endregion

            #region 5.	Display all Students with TrackId =1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            //var q = from student in students
            //        where student.TrackId == 1 && student.Salary > 4000
            //        orderby student.FName descending
            //        select student;
            #endregion

            #region 6.Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
            //var q = students.Where(student => student.TrackId == 1 && student.FName!.ToLower().Contains("m"))
            //                .OrderBy(student => student.Salary) ;
            #endregion

            #region 7.	Find First Student with Salary more than 5000. 
            //var q = students.First(student => student.Salary>5000);
            //var q = students.FirstOrDefault(student => student.Salary>50000);
            #endregion

            #region 8.	Find Last Student in Track number 10.
            //var q = students.Last(student => student.Id == 2);
            //var q = students.LastOrDefault(student => student.Id == 20);
            #endregion

            #region 9.Find Student with Age equal 25.
            //var q = students.Single(student => student.Age == 22); // exception if no items or more than one items 
            //var q = students.SingleOrDefault(student => student.Age == 23); // exception if more than one items match the criteria
            #endregion

            #region 10.	Find Student with TrackId equal 8.
            //var q = students.Single(student => student.TrackId == 8);
            //var q = students.SingleOrDefault(student => student.TrackId == 8);
            #endregion

            #region 11.	Find Student in index 4.
            //var q = students.ElementAt(4);
            //var q = students.ElementAtOrDefault(4000);
            #endregion

            #region 12.Ask the user for sorting method (by Name,  Age, etc….) and sorting way (ASC. Or DESC.)…. And implement a function named FindStudentsSorted() that displays all Students sorted as the user requested.
            Console.WriteLine("Enter Sorting Method");
            Console.WriteLine("Enter Name or age or salary or age ");
            string sortingBy = Console.ReadLine().ToLower();
            while (sortingBy != "age" && sortingBy != "name" && sortingBy != "salary")
            {
                Console.WriteLine("Invalid input! Please enter: name, age, or salary");
                sortingBy = Console.ReadLine()?.ToLower();
            }
            /**********/
            Console.WriteLine("Enter Sorting Way:");
            Console.WriteLine("Enter ASC or DESC:");
            string sortingWay = Console.ReadLine().ToLower();

            while (sortingWay != "asc" && sortingWay != "desc")
            {
                Console.WriteLine("Invalid input! Please enter: ASC or DESC");
                sortingWay = Console.ReadLine()?.ToLower();
            }


            var q = (sortingBy, sortingWay) switch
            {
                ("name", "asc") => students.OrderBy(s => s.FName),
                ("name", "desc") => students.OrderByDescending(s => s.FName),
                ("age", "asc") => students.OrderBy(s => s.Age),
                ("age", "desc") => students.OrderByDescending(s => s.Age),
                ("salary", "asc") => students.OrderBy(s => s.Salary),
                ("salary", "desc") => students.OrderByDescending(s => s.Salary),
            }; ;




            #endregion

            foreach (var student in q)
            {
                Console.WriteLine(student);
            }

            //Console.WriteLine(q);
        }
    }
}
