using System;

namespace Github
{
    public class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter coefficients a, b and c separated by spaces: ");
            string? input = Console.ReadLine();
            string[] inputs = input?.Split(' ') ?? [];

            if (inputs.Length == 3 && double.TryParse(inputs[0], out double a) && double.TryParse(inputs[1], out double b) && double.TryParse(inputs[2], out double c))
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("Two distinct real roots: {0} and {1}", root1, root2);
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine("One real root: {0}", root);
                }
                else
                {
                    Console.WriteLine("No real roots");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}