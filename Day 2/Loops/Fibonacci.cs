using System;

namespace Github
{
    /// <summary>
    /// Displays the Fibonacci series up to a given number of terms.
    /// </summary>
    public class Fibonacci
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter a positive integer: ");
            bool check = int.TryParse(Console.ReadLine(), out int n);
            #endregion

            #region Processing
            if (check && n > 0)
            {
                int a = 0, b = 1, c;
                Console.Write("Fibonacci series up to {0} terms: ", n);

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            #endregion
        }
    }
}
