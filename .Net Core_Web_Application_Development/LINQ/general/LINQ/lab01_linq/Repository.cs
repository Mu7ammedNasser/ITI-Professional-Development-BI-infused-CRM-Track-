using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_linq
{
    internal class Repository
    {
        public static List<Student> GetAllStudents()
        {
            //return new List<Student>()
            //    {
            //        new Student{Id=1, FName="Mohamed", LName="Nasser", Age= 22, Salary= 30_000, TrackId = 1 },
            //        new Student{Id=2, FName="Ahmed", LName="Ali", Age= 25, Salary= 45_000, TrackId = 2 },
            //        new Student{Id=3, FName="Ali", LName="Hassan", Age= 21, Salary= 28_000, TrackId = 1 },
            //        new Student{Id=4, FName="Mai", LName="Ibrahim", Age= 23, Salary= 35_000, TrackId = 3 },
            //        new Student{Id=5, FName="Yassmin", LName="Mohamed", Age= 24, Salary= 40_000, TrackId = 2 },
            //        new Student{Id=6, FName="Malak", LName="Khalil", Age= 22, Salary= 32_000, TrackId = 1 },
            //    };

            return
                [
                    new (){Id=1, FName="Mohamed", LName="Nasser", Age= 22, Salary= 30_000, TrackId = 1 },
                    new (){Id=2, FName="Ahmed", LName="Ali", Age= 25, Salary= 45_000, TrackId = 2 },
                    new (){Id=3, FName="Ali", LName="Hassan", Age= 21, Salary= 28_000, TrackId = 1 },
                    new (){Id=4, FName="Mai", LName="Ibrahim", Age= 23, Salary= 35_000, TrackId = 3 },
                    new (){Id=5, FName="Yassmin", LName="Mohamed", Age= 24, Salary= 40_000, TrackId = 2 },
                    new (){Id=6, FName="Malak", LName="Khalil", Age= 22, Salary= 32_000, TrackId = 1 },
                ];

        }

        public static List<Track> GetAllTracks()
        {
            //return new List<Track>()
            //{
            //    new (){TrackId=1, TrackName="CS" },
            //    new (){TrackId=2, TrackName="IS" },
            //    new (){TrackId=3, TrackName="AI" }
            //};

            return
            [
                new (){TrackId=1, TrackName="CS" },
                new (){TrackId=2, TrackName="IS" },
                new (){TrackId=3, TrackName="AI" }
            ];

        }
    }
}
