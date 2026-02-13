// using System;
// using System.Collections.Generic;

// public class ECommerceCartConsolidation
// {
//     public static void Main()
//     {
//         List<(string sku, int qty)> scans = [("A101", 2), ("B205", 1), ("A101", 3), ("C111", -1)];
//         Dictionary<string, int> keyValuePairs = [];
        
//         // Better Performance
//         foreach (var (sku, qty) in scans)
//         {
//             if (qty > 0)
//             {
//                 if (keyValuePairs.ContainsKey(sku)) keyValuePairs[sku] += qty;
//                 else keyValuePairs[sku] = qty;
//             }
//         }
//         foreach (var pair in keyValuePairs) { Console.WriteLine($"SKU: {pair.Key}, Quantity: {pair.Value}"); }

//         //LINQ - Better Readability
//         var result = scans.Where(e => e.qty > 0).GroupBy(e => e.sku)
//                           .ToDictionary(e => e.Key, e => e.Sum(e => e.qty));

//         foreach (var pair in result) { Console.WriteLine($"SKU: {pair.Key}, Quantity: {pair.Value}"); }
//     }
// }