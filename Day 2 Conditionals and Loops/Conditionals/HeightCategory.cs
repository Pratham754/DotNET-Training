using System;

namespace Github
{
    public class HeightCategory
    {
        static void Main()
        {
            Console.Write("Enter height in cm: ");
            int height = int.TryParse(Console.ReadLine(), out int h) ? h : 0;
            Console.WriteLine(height < 0 ? "Invalid input" : height < 150 ? "Dwarf" : height <= 165 && height >= 150 ? "Average"  : height >= 165 && height <= 190 ? "Tall" : "Abnormal");
        }
    }
}
