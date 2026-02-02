using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    struct HiringDate
    {
        #region properties
        int day;
        int month;
        int year;
        #endregion

        #region ctor
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        #endregion

        #region seter & getter
        public void SetDay(int _date) { day = _date; }
        public void SetMonth(int _month) { month = _month; }
        public void SetYear(int _year) { year = _year; }

        public int GetDay() { return day; }
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
        #endregion

        #region print method
        public string Print()
        {
            return $"Hiring Date: {day}/{month}/{year}";
        }
        #endregion

    }
}
