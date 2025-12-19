using System;

namespace Github
{
    public class QuadrantFinder
    {
        static void Main()
        {
            Console.Write("Enter x coordinate: ");
            bool isXValid = double.TryParse(Console.ReadLine(), out double x);
            Console.Write("Enter y coordinate: ");
            bool isYValid = double.TryParse(Console.ReadLine(), out double y);

            if (!isXValid || !isYValid)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in Quadrant 1", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in Quadrant 2", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in Quadrant 3", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in Quadrant 4", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The point is at the Origin");
            }
            else if (x == 0)
            {
                Console.WriteLine("The point lies on the Y-axis");
            }
            else // y == 0
            {
                Console.WriteLine("The point lies on the X-axis");
            }
        }
    }
}