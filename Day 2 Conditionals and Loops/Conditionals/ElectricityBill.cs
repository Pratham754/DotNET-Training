using System;

namespace Github
{
    /// <summary>
    /// This class calculates the electricity bill based on
    /// the number of units consumed using slab rates.
    /// </summary>
    class Electricity
    {
        /// <summary>
        /// Main method: Entry point of the program.
        /// </summary>
        public static void Main()
        {
            #region User Input Section
            // Prompt the user to enter the number of units consumed
            Console.Write("Enter the amount of units consumed: ");
            #endregion

            #region Input Validation Section
            // Validate the input and ensure units are non-negative
            if(int.TryParse(Console.ReadLine(), out int units) && units >= 0)
            {
                #region Bill Calculation Section
                // Initialize bill amount
                double bill = 0;

                // Calculate bill based on consumption slabs
                if(units <= 199)
                {
                    // Slab 1: Up to 199 units
                    bill = units * 1.20;
                }
                else if(units <= 400)
                {
                    // Slab 2: 200 to 400 units
                    bill = (199 * 1.20) + ((units - 199) * 1.50);
                }
                else if(units <= 600)
                {
                    // Slab 3: 401 to 600 units
                    bill = (199 * 1.20) + (201 * 1.50) + ((units - 400) * 1.80);
                }
                else
                {
                    // Slab 4: Above 600 units
                    bill = (199 * 1.20) + (201 * 1.50) + (200 * 1.80) + ((units - 600) * 2.00);
                }

                // Apply surcharge if bill exceeds 400
                if(bill > 400)
                {
                    bill += bill * 0.15;
                }

                // Display the final bill amount
                Console.WriteLine("The total electricity bill is: {0:F2}", bill);
                #endregion
            }
            #endregion
        }
    }
}
