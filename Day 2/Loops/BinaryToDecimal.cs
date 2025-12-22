using System;

namespace Github
{
    /// <summary>
    /// Converts a binary number to its decimal equivalent.
    /// </summary>
    public class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            #region Input
            Console.WriteLine("Enter a binary number:");
            string binaryString = Console.ReadLine() ?? "";
            #endregion

            #region Processing
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
            #endregion
        }
    }
}
