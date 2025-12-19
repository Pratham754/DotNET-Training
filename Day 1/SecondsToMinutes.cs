using System;

namespace TimeConversion
{
    public class Github
    {
        static void Main()
        {
            Console.Write("Enter time in seconds: ");
            bool check = int.TryParse(Console.ReadLine(), out int seconds);
            if(check && seconds >= 0)
            {
                int minute = seconds / 60;
                int remainingSeconds = seconds % 60;
                Console.WriteLine("{0} seconds is equal to {1} minutes and {2} seconds", seconds, minute, remainingSeconds);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        
    }
}