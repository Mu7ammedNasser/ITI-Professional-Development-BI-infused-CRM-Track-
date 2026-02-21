using EFCore_day01_DEMO.Context;
using EFCore_day01_DEMO.Models;

namespace Day02_EF_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext db = new MyContext();

            #region MIGRATION
            //step 01
            //create migration 
            // add-migration migrationName

            //step 02
            // update-database
            #endregion

            #region CRUD
            //var dept = new Department() { DeptName = "IT" };
            //db.Add(dept);
            //db.SaveChanges();
            #endregion
        }
    }
}
