using System;
using System.Text.RegularExpressions;

namespace MyconsoleApp
{
    /// <summary>
    /// Demonstrates usage of Regular Expressions (Regex)
    /// to perform case-insensitive pattern matching.
    /// </summary>
    public class RegEx
    {
        #region Program Entry Point

        /// <summary>
        /// Main method – application execution starts here.
        /// Checks whether a specific keyword exists in the input string
        /// using Regex with timeout and ignore-case options.
        /// </summary>
        static void Main()
        {
            // Input string to be searched
            string input = "Error: TIMEOUT while calling API";

            // Regex pattern to search for
            string pattern = @"timeout";

            // Create Regex object with options:
            // IgnoreCase  -> case-insensitive matching
            // Timeout     -> prevents long-running regex execution
            var rx = new Regex(
                pattern,
                RegexOptions.IgnoreCase,
                TimeSpan.FromMilliseconds(150)
            );

            // Check if pattern exists in input string
            if (rx.IsMatch(input))
            {
                Console.WriteLine("Match found");
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }

        #endregion
    }
}
