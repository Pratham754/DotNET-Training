// Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue.
using System;
namespace Github
{
    public class ContinueUsage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 50, skipping multiples of 3:");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}