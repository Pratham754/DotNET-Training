using System;

class Program
{
    static void Main()
    {
        double m1, m2, m3, m4, m5;

        Console.Write("Enter Marks for Subject 1: ");
        if (!double.TryParse(Console.ReadLine(), out m1) || m1 < 0 || m1 > 100)
        {
            Console.WriteLine("Invalid marks.");
            return;
        }

        Console.Write("Enter Marks for Subject 2: ");
        if (!double.TryParse(Console.ReadLine(), out m2) || m2 < 0 || m2 > 100)
        {
            Console.WriteLine("Invalid marks.");
            return;
        }

        Console.Write("Enter Marks for Subject 3: ");
        if (!double.TryParse(Console.ReadLine(), out m3) || m3 < 0 || m3 > 100)
        {
            Console.WriteLine("Invalid marks.");
            return;
        }

        Console.Write("Enter Marks for Subject 4: ");
        if (!double.TryParse(Console.ReadLine(), out m4) || m4 < 0 || m4 > 100)
        {
            Console.WriteLine("Invalid marks.");
            return;
        }

        Console.Write("Enter Marks for Subject 5: ");
        if (!double.TryParse(Console.ReadLine(), out m5) || m5 < 0 || m5 > 100)
        {
            Console.WriteLine("Invalid marks.");
            return;
        }

        double total = m1 + m2 + m3 + m4 + m5;
        double average = total / 5;
        double percentage = (total / 500) * 100;

        Console.WriteLine("\n----- RESULT -----");
        Console.WriteLine($"Total Marks : {total}");
        Console.WriteLine($"Average     : {Math.Round(average, 2)}");
        Console.WriteLine($"Percentage  : {Math.Round(percentage, 2)}%");
    }
}