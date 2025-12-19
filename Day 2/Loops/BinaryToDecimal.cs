using System;
namespace Github
{
    public class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number:");
            string binaryString = Console.ReadLine() ?? "";
            int decimalValue = 0;
            int length = binaryString.Length;

            for (int i = 0; i < length; i++)
            {
                char bit = binaryString[length - 1 - i];
                if (bit == '1')
                {
                    decimalValue += (1 << i);
                }
                else if (bit != '0')
                {
                    Console.WriteLine("Invalid binary number");
                    return;
                }
            }

            Console.WriteLine($"The decimal value is: {decimalValue}");
        }
    }
}