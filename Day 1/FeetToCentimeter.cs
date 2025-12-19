using System;

namespace Github
{
    public class FeetToCentimeter
    {
        static void Main()
        {
            Console.Write("Enter length in feet: ");
            bool check = double.TryParse(Console.ReadLine(), out double feet);
            if(check && feet >= 0)
            {
                double centimeters = feet * 30.48;
                Console.WriteLine("{0} feet is equal to {1} centimeters", feet, centimeters);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}