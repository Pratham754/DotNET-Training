using System;

namespace Github
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
            {
                string result = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? $"{year} is a leap year" : $"{year} is not a leap year";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}