using System;

namespace Github
{
    class TriangleType
    {
        static void Main()
        {
            Console.Write("Enter side A length: ");
            bool checkA = double.TryParse(Console.ReadLine(), out double sideA);
            Console.Write("Enter side B length: ");
            bool checkB = double.TryParse(Console.ReadLine(), out double sideB);
            Console.Write("Enter side C length: ");
            bool checkC = double.TryParse(Console.ReadLine(), out double sideC);

            if (checkA && checkB && checkC && sideA > 0 && sideB > 0 && sideC > 0)
            {
                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (sideA == sideB || sideB == sideC || sideA == sideC)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}