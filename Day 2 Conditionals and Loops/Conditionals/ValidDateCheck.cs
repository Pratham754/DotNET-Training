using System;

namespace Github
{
    public class ValidDateCheck
    {
        public static bool IsValidDate(int day, int month, int year)
        {
            // Check for valid month
            if (month < 1 || month > 12)
                return false;

            // Days in each month
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Check for leap year for February days
            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            // Check for valid day
            if (day < 1 || day > daysInMonth[month - 1])
                return false;

            return true;
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}