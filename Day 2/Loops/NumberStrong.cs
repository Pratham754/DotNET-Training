// Strong Number: Check if the sum of the factorial of digits is equal to the number itself.
using System;
namespace Github
{
    public class NumberStrong
    {
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it's a strong number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sumOfFactorials = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfFactorials += Factorial(digit);
                number /= 10;
            }

            if (sumOfFactorials == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is a strong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a strong number.");
            }
        }
    }
}