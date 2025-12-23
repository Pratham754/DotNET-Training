using System;

namespace Github
{
    public class Factorial
    {
        static void Main()
        {
            Console.Write("Enter a non-negative integer: ");
            bool check = int.TryParse(Console.ReadLine(), out int n);
            if (check && n >= 0)
            {
                try
                {
                    System.Numerics.BigInteger factorial = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Factorial of {0} is: {1}", n, factorial);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large to compute its factorial.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}