// Pascal's Triangle: Use Nested Loops to print Pascal's triangle up to N rows.
using System;
namespace Github
{
    public class PascalTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for Pascal's Triangle:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Print leading spaces
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                int number = 1;
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number = number * (i - k) / (k + 1);
                }
                Console.WriteLine();
            }
        }
    }
}