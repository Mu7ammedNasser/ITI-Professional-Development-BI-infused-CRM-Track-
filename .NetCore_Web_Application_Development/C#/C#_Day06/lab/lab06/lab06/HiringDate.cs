using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal struct HiringDate :IComparable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get ; set ; }

        #region ctor
        public HiringDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        //public double convertDate()

        #endregion

        public override string ToString()
        {
            return $"Hiring Date: {Day}/{Month}/{Year}";
        }

        public int CompareTo(object? obj)
        {
            var hiringDate = (HiringDate)obj!;
            if (Year != hiringDate.Year)
                return Year.CompareTo(hiringDate.Year);
            else if (Month != hiringDate.Month)
                return Month.CompareTo(hiringDate.Month);
            else
                return Day.CompareTo(hiringDate.Day);
        }
    }
}
