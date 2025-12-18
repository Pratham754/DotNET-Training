using System;

namespace Circle
{
    class AreaCircle
    {
        static void Main()
        {
            Console.Write("Enter circle radius: ");
            bool check = double.TryParse(Console.ReadLine(), out double rad);
            if(check && rad > 0)
            {
                double area = Math.PI * rad * rad;
                Console.WriteLine("Area of circle is: {0}", area);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}