using System;

namespace Github
{
    public class Armstrong()
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                if(int.TryParse(Console.ReadLine(), out int num) && num >= 0){
                    int originalNum = num, sum = 0, digits = 0;
                    while(originalNum != 0)
                    {
                        digits++;
                        originalNum /= 10;
                    }
                    originalNum = num;
                    while(originalNum != 0)
                    {
                        int digit = originalNum % 10;
                        sum += (int)Math.Pow(digit, digits);
                        originalNum /= 10;
                    }
                    Console.WriteLine(sum == num ? $"{num} is an Armstrong Number" : $"{num} is not an Armstrong Number");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input: " + ex.Message);
            }
        }
    }
}