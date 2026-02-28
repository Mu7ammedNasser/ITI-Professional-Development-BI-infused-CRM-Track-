using EFCore_Day03_lab.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Day03_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ITIContext();
            Console.WriteLine("Hello, World!");

            #region Find Method
            /// Find Retrun Single Record By Primary Key
            /// Find(PK[])
            /// By Default
            /// - Search in Local Momory (Cache) if Found Return it
            /// - If Not Found Search in Database and Return it and Save it in Local Momory (Cache)
            /// - If Not Found Return Null
            /// - And No Errors

            var studs = db.Students.AsNoTracking().ToList();

            var emp1 = db.Students.Find(1);
            if (emp1 is not null)
            {
                Console.WriteLine(emp1.StFname);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            #endregion

            #region AsQueryable vs AsEnumerable
            var q1 = db.Students.AsQueryable(); // deffered execution , execute in database, System.Linq.Queryable
            var q1F = q1.Where(e => e.StAge == 24).ToList();
            foreach (var item in q1F)
            {
                Console.WriteLine(item.StFname);
            }

            var q2 = db.Students.AsEnumerable(); // Immediate execution, execute in memory, System.Collections
            var q2F = q2.Where(e => e.StAge == 24).ToList();
            foreach (var item in q2F)
            {
                Console.WriteLine(item.StFname);
            }

            #endregion


        }
    }
}
