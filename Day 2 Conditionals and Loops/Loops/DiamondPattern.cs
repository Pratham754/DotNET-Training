using System;
namespace Github
{
    public class DiamondPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for the diamond:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Upper half including middle row
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower half
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}