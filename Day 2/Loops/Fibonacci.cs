using System;

namespace Github
{
    public class Fibonacci
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a positive integer: ");
                bool check = int.TryParse(Console.ReadLine(), out int n);
                
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}