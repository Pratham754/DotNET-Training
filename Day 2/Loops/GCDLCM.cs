// GCD and LCM: Find the Greatest Common Divisor and Least Common Multiple of two numbers.
using System;
namespace Github
{
    public class GCDLCM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);
            int lcm = (num1 * num2) / gcd;

            Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
            Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}