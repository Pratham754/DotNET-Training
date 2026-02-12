using System;

public class InputHandler
{
    public static void Main()
    {
        // TODO:
        bool valid = false;
        try
        {
            // 3. Keep asking until valid number is entered
            while (!valid)
            {
                // 1. Read input from user
                string input = Console.ReadLine();
                foreach (char ch in input)
                {
                    if (!char.IsDigit(ch))
                    {
                        // 2. Handle invalid numeric input
                        throw new FormatException();
                    }
                }
                valid = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}