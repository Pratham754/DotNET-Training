using System;

namespace Github
{
    public class PrimeNumber
    {
        static void Main()
        {
            try
            {
                
                Console.Write("Enter the number to check prime or not: ");
                int num = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;
                for(int i=2; i<=Math.Sqrt(num); i++)
                {
                    if(num%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime ? $"{num} is a Prime Number" : $"{num} is Not a Prime Number");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input: " + ex.Message);
            }
        }
    }
}