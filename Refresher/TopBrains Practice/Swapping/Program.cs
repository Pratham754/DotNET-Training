using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        public static void swapRef(ref int num1,ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        public static void swapOut(int num1, int num2,out int x, out int y)
        {
            x = num2;
            y = num1;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("First number: "+num1);
            Console.WriteLine("Second number: " + num2);

            swapRef(ref num1,ref num2);

            Console.WriteLine("After swapping with ref:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);

            int x, y;

            swapOut(num1,num2, out x,out y);

            Console.WriteLine("After swapping with out:");
            Console.WriteLine("First number: " + x);
            Console.WriteLine("Second number: " + y);

        }
    }
}
