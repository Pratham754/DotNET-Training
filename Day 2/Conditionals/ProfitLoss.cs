// Profit/Loss: Calculate profit or loss percentage based on Cost Price and Selling Price.
using System;

namespace Github
{
    public class ProfitLoss
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the Cost Price: ");
                decimal costPrice = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the Selling Price: ");
                decimal sellingPrice = Convert.ToDecimal(Console.ReadLine());

                if (costPrice > 0 && sellingPrice > 0)
                {
                    decimal profitLoss = sellingPrice - costPrice;
                    decimal percentage = (profitLoss / costPrice * 100);

                    if (profitLoss > 0)
                    {
                        Console.WriteLine($"Profit Percentage: {percentage:F2}%");
                    }
                    else if (profitLoss < 0)
                    {
                        Console.WriteLine($"Loss Percentage: {Math.Abs(percentage):F2}%");
                    }
                    else
                    {
                        Console.WriteLine("No Profit, No Loss.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter positive values for Cost Price and Selling Price.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}