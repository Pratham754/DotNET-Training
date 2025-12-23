using System;

namespace Github
{
    /// <summary>
    /// Checks whether a string is a palindrome.
    /// </summary>
    public class Palindrome
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            #endregion

            #region Processing
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
                reversed += input[i];

            Console.WriteLine(input.Equals(reversed, StringComparison.OrdinalIgnoreCase)
                ? $"\"{input}\" is a palindrome."
                : $"\"{input}\" is not a palindrome.");
            #endregion
        }
    }
}
