// Sum of Digits: Repeatedly sum digits of a number until the result is a single digit (Digital Root).
using System;
namespace Github
{
    public class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its digital root: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number >= 10)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }

            Console.WriteLine($"The digital root is: {number}");
        }
    }
}