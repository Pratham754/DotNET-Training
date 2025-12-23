using System;

namespace Github
{
    /// <summary>
    /// This class performs basic arithmetic calculations
    /// based on the provided operator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Calculates the result of an arithmetic operation between two numbers.
        /// </summary>
        /// <param name="num1">The first decimal number.</param>
        /// <param name="num2">The second decimal number.</param>
        /// <param name="operation">The arithmetic operator (+, -, *, /).</param>
        /// <returns>The result of the calculation or an error message.</returns>
        public static string Calculate(decimal num1, decimal num2, char operation)
        {
            #region Variable Declaration Section
            // Variable to store the calculation result
            decimal result;
            #endregion

            #region Operation Selection Section
            // Determine the operation to perform based on the operator
            switch (operation)
            {
                case '+':
                    // Perform addition
                    result = num1 + num2;
                    return $"Result: {result}";

                case '-':
                    // Perform subtraction
                    result = num1 - num2;
                    return $"Result: {result}";

                case '*':
                    // Perform multiplication
                    result = num1 * num2;
                    return $"Result: {result}";

                case '/':
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        // Perform division
                        result = num1 / num2;
                        return $"Result: {result}";
                    }
                    else
                    {
                        // Handle division by zero error
                        return "Error: Division by zero is not allowed.";
                    }

                default:
                    // Handle invalid operator input
                    return "Invalid operation. Please use +, -, *, or /.";
            }
            #endregion
        }
    }
}
