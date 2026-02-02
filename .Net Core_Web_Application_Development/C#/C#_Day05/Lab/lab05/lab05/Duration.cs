using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }

        public Duration()
        {
           this.Hours = 0;
           this.Min = 0;
           this.Sec = 0;
        }
        public Duration(int hours , int min , int sec)
        {
            this.Hours = hours;
            this.Min = min;
            this.Sec = sec;
        }
        public Duration(int sec) 
        {
            int hoursReminder = sec % (60 * 60);

            this.Hours= sec / (60*60);
            this.Min = hoursReminder / 60;

            int minReminder =hoursReminder % 60;
            this.Sec = minReminder;
        }

        public static Duration operator +(Duration left, Duration right)
        {
            
            return new()
            {
                Hours = left.Hours + right.Hours,
                Min = left.Min + right.Min,
                Sec = left.Sec + right.Sec,
            };
        }

        public static Duration operator +(Duration left, int sec)
        {
            return new Duration(left.Hours * 3600 + left.Min * 60 + left.Sec + sec);
        }
        public static Duration operator +(int sec ,Duration right)
        {
            return new Duration(right.Hours * 3600 + right.Min * 60 + right.Sec + sec);
        }

        public static Duration operator ++( Duration right)
        {
            return new Duration( right.Hours,right.Min++ , right.Sec);
        }
        public static Duration operator --(Duration right)
        {
            if(right.Min > 0)
            {
                return new Duration(right.Hours, right.Min--, right.Sec);

            }
                return new Duration(right.Hours, 0, right.Sec);
        }

        public static bool operator >(Duration left , Duration right)
        {
            return (right.Hours * 3600 + right.Min * 60 + right.Sec ) > (right.Hours * 3600 + right.Min * 60 + right.Sec);
        }

        public static bool operator <(Duration left, Duration right)
        {
            return (right.Hours * 3600 + right.Min * 60 + right.Sec) <(right.Hours * 3600 + right.Min * 60 + right.Sec);
        }




        public override string ToString()
        {
            return
                $"{(Hours > 0 ? $"Hours: {Hours} " : "")}" +
                $"{(Min > 0 ? $"Minutes: {Min} " : "")}" +
                $"{(Sec > 0 ? $"Seconds: {Sec}" : "")}";
        }
    }
}
