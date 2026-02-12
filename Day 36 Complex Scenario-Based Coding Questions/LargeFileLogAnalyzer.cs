using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LargeFileLogAnalyzer
{
    public record ErrorSummary(string ErrorCode, int Count);

    public class LogAnalyzer
    {
        // Regex for finding "ERR" followed by digits
        private static readonly Regex ErrorRegex = new(@"ERR\d+");

        public static IEnumerable<ErrorSummary> GetTopErrors(string filePath, int topN)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("File not found");

            return File.ReadLines(filePath) // Streams line by line
                .Select(line => ErrorRegex.Match(line).Value) // Find the error code
                .Where(code => !string.IsNullOrEmpty(code)) // Filter out lines with no error
                .GroupBy(code => code) // Group identical codes
                .Select(group => new ErrorSummary(group.Key, group.Count())) // Create summary
                .OrderByDescending(x => x.Count) // Sort by highest frequency
                .Take(topN); // Only take the top N
        }
    }

    public class Program
    {
        public static void Main()
        {
            var results = LogAnalyzer.GetTopErrors("app_log.txt", 5);
            foreach (var error in results)
                Console.WriteLine($"{error.ErrorCode}: {error.Count}");
        }
    }
}