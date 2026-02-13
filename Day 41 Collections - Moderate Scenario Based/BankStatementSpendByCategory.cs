// using System;
// using System.Collections.Generic;

// public class BankStatementSpendByCategory
// {
//     public static void Main()
//     {
//         List<(string category, decimal amount)> txns = [("Food", -200), ("Fuel", -500), ("Food", -50), ("Salary", 1000)];

//         Dictionary<string, decimal> spendByCategory = txns.Where(t => t.amount < 0).GroupBy(t => t.category)
//                                                           .ToDictionary(g => g.Key, g => g.Sum(t => t.amount));

//         foreach (var pair in spendByCategory) { Console.WriteLine($"{pair.Key}: {pair.Value * -1}"); }
//     }
// }