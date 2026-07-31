using System;

class Program
{
    static void Main()
    {
        double weight, height;

        Console.Write("Enter Weight (kg): ");
        if (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.WriteLine("Invalid weight.");
            return;
        }

        Console.Write("Enter Height (m): ");
        if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid height.");
            return;
        }

        double bmi = weight / (height * height);

        Console.WriteLine($"\nBMI = {Math.Round(bmi, 2)}");

        if (bmi < 18.5)
            Console.WriteLine("Category: Underweight");
        else if (bmi < 25)
            Console.WriteLine("Category: Normal Weight");
        else if (bmi < 30)
            Console.WriteLine("Category: Overweight");
        else
            Console.WriteLine("Category: Obese");
    }
}