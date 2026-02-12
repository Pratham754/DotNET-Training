using System;
using System.Collections.Generic;
using System.IO;

namespace CsvImportWithPartialSucess
{
    public class ImportResult
    {
        public int InsertedCount { get; set; }
        public List<string> Errors { get; } = new();
    }

    public class ProductImporter
    {
        public static ImportResult ImportProduct(string csvPath)
        {
            var res = new ImportResult();
            int rowNumber = 0;

            foreach (var line in File.ReadLines(csvPath))
            {
                rowNumber++;
                if (rowNumber == 1 || string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    ParseLine(line);
                    res.InsertedCount++;
                } catch (Exception ex)
                {
                    res.Errors.Add($"Row {rowNumber}: {ex.Message}");
                }
            }
            return res;
        }

        private static void ParseLine(string line)
        {
            var parts = line.Split(',');
            if (parts.Length < 2) throw new Exception("Columns Are Missing!");
            string name = parts[0].Trim();
            if (string.IsNullOrEmpty(name)) throw new Exception("Product Name is Missing!");
            if (!decimal.TryParse(parts[1], out decimal price)) throw new Exception(" Price Format Is Incorrect!");
            if (price < 0) throw new Exception("Price Cannot Be Zero!");
        }
    }

    public class MainProgram
    {
        public static void Main()
        {
            string csv = "Name,Price\nLaptop,1000\n,ten\nMouse,25";
            File.WriteAllText("data.csv");

            var importer = new ProductImporter();
            var report = ProductImporter.ImportProduct("data.csv");
            report.Errors.ForEach(e => Console.WriteLine($"Error -> {e}"));
        }
    }
}