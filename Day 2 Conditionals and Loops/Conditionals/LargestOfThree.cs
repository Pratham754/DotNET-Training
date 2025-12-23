using System;

namespace Github
{
    /// <summary>
    /// Finds and displays the largest of three numbers.
    /// </summary>
    public class LargestOfThree
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter three numbers separated by spaces: ");
            string? input = Console.ReadLine();
            string[] inputs = input?.Split(' ') ?? [];
            #endregion

            #region Processing
            if (inputs.Length == 3 &&
                double.TryParse(inputs[0], out double num1) &&
                double.TryParse(inputs[1], out double num2) &&
                double.TryParse(inputs[2], out double num3))
            {
                double largest = num1 >= num2 ? (num1 >= num3 ? num1 : num3) : (num2 >= num3 ? num2 : num3);
                Console.WriteLine("The largest number is: {0}", largest);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            #endregion
        }
    }
}
