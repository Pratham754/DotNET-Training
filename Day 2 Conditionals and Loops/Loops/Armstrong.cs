using System;

namespace Github
{
    /// <summary>
    /// Checks whether a number is an Armstrong number.
    /// </summary>
    public class Armstrong
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter a number: ");
            #endregion

            #region Processing
            if(int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                int originalNum = num, sum = 0, digits = 0;

                // Count number of digits
                while(originalNum != 0)
                {
                    digits++;
                    originalNum /= 10;
                }

                originalNum = num;

                // Calculate sum of powers of digits
                while(originalNum != 0)
                {
                    int digit = originalNum % 10;
                    sum += (int)Math.Pow(digit, digits);
                    originalNum /= 10;
                }

                // Display result
                Console.WriteLine(sum == num ? $"{num} is an Armstrong Number" : $"{num} is not an Armstrong Number");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            #endregion
        }
    }
}
