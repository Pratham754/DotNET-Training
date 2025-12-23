using System;

namespace Github
{
    /// <summary>
    /// Calculates and displays profit or loss percentage based on cost and selling price.
    /// </summary>
    public class ProfitLoss
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter the Cost Price: ");
            decimal costPrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the Selling Price: ");
            decimal sellingPrice = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region Processing
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
                Console.WriteLine("Invalid input. Please enter positive values.");
            }
            #endregion
        }
    }
}
