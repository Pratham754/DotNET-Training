using System;

class Program
{
    static void Main()
    {
        double length, width, height;

        Console.Write("Enter Length: ");
        if (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid length.");
            return;
        }

        Console.Write("Enter Width: ");
        if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.WriteLine("Invalid width.");
            return;
        }

        Console.Write("Enter Height: ");
        if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid height.");
            return;
        }

        double volume = length * width * height;

        Console.WriteLine($"\nPackage Volume = {Math.Round(volume, 2)} cubic units");
    }
}