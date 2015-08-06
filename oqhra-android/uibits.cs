using System;
using System.Collections.Generic;

namespace oqhra_android
{
    public class calendar
    {
        private List<int> daysInMonth;

        public calendar()
        {
            daysInMonth = new List<int>();
            daysInMonth.AddRange(new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 });
        }

        private int determineDayCode(int year)
        {
            int d1, d2, d3;
            d1 = (year - 1) / 4;
            d2 = (year - 1) / 100;
            d3 = (year - 1) / 400;
            return Convert.ToInt32((year + d1 - d2 + d3) % 7);
        }

        private void checkForLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                daysInMonth[2] = 29;
            else
                daysInMonth[2] = 28;
        }

        private List<int> createCal(int ddc, int month, int year)
        {
            int day, finddays = 0;
            List<int> cal = new List<int>();
            if (month != 1)
            {
                for (int m = 1; m < month; ++m)
                    finddays += daysInMonth[m];
                ddc += finddays % 7;
            }
            for (day = 1; day <= ddc; ++day)
                cal.Add(0);
            for (day = 1; day <= daysInMonth[month]; ++day)
                cal.Add(day);
            return cal;
        }

        public List<int> generateCalendar(int month, int year)
        {
            List<int> cal = new List<int>();
            int ddc = determineDayCode(year);
            checkForLeapYear(year);
            cal = createCal(ddc, month, year);
            return cal;
        }
    }
}
