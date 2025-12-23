using System;

namespace Github
{
    /// <summary>
    /// Checks whether a number is a Strong number.
    /// </summary>
    public class NumberStrong
    {
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        static void Main(string[] args)
        {
            #region Input
            Console.Write("Enter a number to check if it's a strong number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Processing
            int originalNumber = number;
            int sumOfFactorials = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfFactorials += Factorial(digit);
                number /= 10;
            }

            Console.WriteLine(sumOfFactorials == originalNumber
                ? $"{originalNumber} is a strong number."
                : $"{originalNumber} is not a strong number.");
            #endregion
        }
    }
}
