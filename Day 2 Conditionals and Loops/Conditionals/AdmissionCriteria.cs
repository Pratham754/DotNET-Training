using System;

namespace Github
{
    /// <summary>
    /// This class evaluates whether a student is eligible for admission
    /// based on marks in Mathematics, Physics, and Chemistry.
    /// </summary>
    public class AdmissionCriteria
    {
        // Main method: Entry point of the program
        static void Main()
        {
            #region User Input Section
            // Prompt the user to enter marks for three subjects separated by spaces
            Console.Write("Enter marks for Mathematics, Physics and Chemistry separated by spaces: ");
            
            // Read the input line from the user
            string? input = Console.ReadLine();
            
            // Split the input into individual values
            string[] inputs = input?.Split(' ') ?? [];
            #endregion

            #region Input Validation Section
            // Validate that exactly three values are provided and can be parsed as integers
            if (inputs.Length == 3 &&
                int.TryParse(inputs[0], out int math) &&
                int.TryParse(inputs[1], out int phys) &&
                int.TryParse(inputs[2], out int chem))
            {
                #region Eligibility Calculation Section
                // Calculate the total marks
                int total = math + phys + chem;

                // Check admission eligibility based on given criteria
                if (math >= 65 && phys >= 55 && chem >= 50 &&
                    (total >= 180 || (math + phys) >= 140))
                {
                    // Output eligibility result
                    Console.WriteLine("Eligible for admission");
                }
                else
                {
                    // Output non-eligibility result
                    Console.WriteLine("Not eligible for admission");
                }
                #endregion
            }
            else
            {
                // Handle invalid input format
                Console.WriteLine("Invalid input");
            }
            #endregion
        }
    }
}
